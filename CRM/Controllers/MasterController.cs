using DataAccess;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPI.Models;
using System.Configuration;
using System.Diagnostics;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DataAccess.Model;
using DataAccess.Models;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using CRM.Models;

namespace CRM.Controllers
{
    [RoutePrefix("api/Master")]
    public class MasterController : ApiController
    {

        string BaseURL = System.Configuration.ConfigurationManager.AppSettings["AdminBaseURI"];
        Service s;

        public MasterController()
        {
            s = new Service();
        }


        [Route("Login")]
        [HttpPost]
        public IHttpActionResult Login([FromBody] LoginModel l)
        {
            try
            {
                EmployeeMaster u = s.ManageEmployeeMaster.Get().Where(c => c.IsActive == true && c.IsDisplay == true && c.Username == l.Username && c.Password == l.password).FirstOrDefault();
                ResponseBody RB = new ResponseBody();

                if (u != null)
                {
                    
                    RB.success = true;
                    RB.msg = "Login Successfully";
                    RB.data = u;
                    return Ok(RB);
                }
                else
                {
                    RB.success = false;
                    RB.msg = "Invalid email or password";
                    RB.data = null;
                    return Ok(RB);
                }
            }
            catch (Exception)
            {
                return NotFound();
            }
        }



        [Route("Forgotpassword")]
        [HttpPost]
        public IHttpActionResult forgotpassword([FromBody] ForgotPasswordModel f)
        {
            try
            {
                ResponseBody RB = new ResponseBody();
                if (s.ManageEmployeeMaster.CheckExist(f.Username))
                {
                    EmployeeMaster objUse = s.ManageEmployeeMaster.Forgotpassword(f.Username);

                    if (objUse != null)
                    {

                        EmailCredentialMaster ECM = s.EmailCredential.Get().Where(c => c.EmailCredentialID == 1).FirstOrDefault();


                        EmailTemplateMaster et = s.EmailTemplate.Get().Where(mo => mo.EmailTemplateID == 2).FirstOrDefault();

                        EmailModel e = new EmailModel();
                        e.To = objUse.Email;
                        e.Subject = et.EmailTemplateName;
                        e.Body = et.Description.Replace("##Password##", objUse.Password).Replace("##Name##", objUse.EmployeeName).Replace("##Date##", DateTime.Now.ToString("dd/MM/yyyy"));

                        MailMessage message = new MailMessage();
                        message.From = new MailAddress(ECM.EmailAddress);
                        message.To.Add(new MailAddress(e.To));
                        message.Subject = e.Subject;
                        message.IsBodyHtml = true;
                        message.Body = e.Body;
                        SmtpClient smtp = new SmtpClient(ECM.SMTP, Convert.ToInt32(ECM.Port));
                        smtp.Credentials = new System.Net.NetworkCredential(ECM.EmailAddress, ECM.Password);
                        smtp.EnableSsl = ECM.ISSSL.HasValue ? ECM.ISSSL.Value : false;
                        Task.Factory.StartNew(() => smtp.Send(message));


                        RB.success = true;
                        RB.msg = "Your Account Password has been Sent to your Registered Email Id.";
                        RB.data = "";
                        return Ok(RB);
                    }
                    else
                    {
                        RB.success = false;
                        RB.msg = "Something Went wrong !";
                        RB.data = "";
                        return Ok(RB);
                    }
                }
                else
                {
                    RB.success = false;
                    RB.msg = "This Username does not registred with Us. Please try with valid Username or Contact to your Administrator !";
                    RB.data = "";
                    return Ok(RB);
                }

            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [Route("Changepassword")]
        [HttpPost]
        public IHttpActionResult Changepassword([FromBody] ChangepasswordModel f)
        {

            try
            {
                ResponseBody RB = new ResponseBody();
                EmployeeMaster obj = s.ManageEmployeeMaster.GetPassword(f.EmployeeId, f.OldPassword);
                if (obj != null)
                {
                    obj.Password = f.NewPassword;
                    obj.EmployeeID = f.EmployeeId;
                    obj.IsUpdatedOn = DateTime.Now;
                    s.ManageEmployeeMaster.Update(obj);

                    RB.success = true;
                    RB.msg = "Your Account Password has been Changed.";
                    RB.data = "";
                    return Ok(RB);


                }
                else
                {

                    EmployeeMaster u = s.ManageEmployeeMaster.Get().Where(c=> c.EmployeeID == f.EmployeeId).FirstOrDefault();

                    if(u!= null)
                    {
                        RB.success = false;
                        RB.msg = "Old Password Does Not Match.";
                        RB.data = "";
                        return Ok(RB);
                    }
                    else
                    {
                        RB.success = false;
                        RB.msg = "Something Went wrong !";
                        RB.data = "";
                        return Ok(RB);
                    }
                }

            }
            catch (Exception)
            {
                return NotFound();
            }

        }

        [Route("UpdateMyprofile")]
        [HttpPost]
        public IHttpActionResult UpdateMyprofile(EmployeeMaster_model e)
        {
            EmployeeMaster e1 = s.ManageEmployeeMaster.GetEmployeeById((int)e.EmployeeID);
            e1.EmployeeID = e.EmployeeID;
            e1.EmployeeName = e.EmployeeName;
            e1.MobileNo = e.MobileNo;
            e1.Email = e.Email;
            e1.Skill = e.Skill;
            e1.CountryID = e.CountryID;
            if(e.CountryID != null)
            {
                CountryMaster u = s.Country.Get((int)e.CountryID);
                e1.CountryName = u.CountryName;
            }
            else
            {
                e1.CountryName = e.CountryName;
            }

            e1.StateID = e.StateID;
            if (e.StateID != null)
            {
                StateMaster u = s.State.Get((int)e.StateID);
                e1.StateName = u.StateName;
            }
            else
            {
                e1.StateName = e.StateName;
            }

            e1.CityID = e.CityID;
            if (e.CityID != null)
            {
                CityMaster u = s.City.Get((int)e.CityID);
                e1.CityName = u.CityName;
            }
            else
            {
                e1.CityName = e.CityName;
            }

            e1.Pincode = e.Pincode;
            e1.Linkedin = e.Linkedin;
            e1.Website = e.Website;
            e1.Github = e.Github;
            e1.AboutDescription = e.AboutDescription;
            e1.ProfileImage = e.ProfileImage;

            s.ManageEmployeeMaster.Update(e1);
            ResponseBody RB = new ResponseBody();
            if (e1 != null)
            {
                RB.success = true;
                RB.msg = "Profile Updated Successfully";
                RB.data = e1.EmployeeID;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "Something Went wrong!";
                RB.data = null;
                return Ok(RB);
            }


        }

        [Route("UpdateMyPicture")]
        [HttpPost]
        public IHttpActionResult UpdateMyPicture(EmployeeImageModel e)
        {
            EmployeeMaster e1 = s.ManageEmployeeMaster.GetEmployeeById((int)e.EmployeeID);
            e1.ProfileImage = e.ProfileImage;

            s.ManageEmployeeMaster.Update(e1);
            ResponseBody RB = new ResponseBody();
            if (e1 != null)
            {
                RB.success = true;
                RB.msg = "Profile Picture Updated Successfully";
                RB.data = e1.EmployeeID;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "Something Went wrong!";
                RB.data = null;
                return Ok(RB);
            }


        }

        [Route("GetAllDesignationList")]
        [HttpGet]
        public IHttpActionResult GetAllDesignationList()
        {
            List<DesignationMaster> u = s.Designation.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetDesignationbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetDesignationbyId(decimal Id)
        {
            DesignationMaster u = s.Designation.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllYearList")]
        [HttpGet]
        public IHttpActionResult GetAllYearList()
        {
            List<YearMaster> u = s.ManageYear.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetYearbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetYearbyId(decimal Id)
        {
            YearMaster u = s.ManageYear.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        
        [Route("GetAllBankAccountList")]
        [HttpGet]
        public IHttpActionResult GetAllBankAccountList()
        {
            List<BankACTypeMaster> u = s.BankAccount.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetBankAccountbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetBankAccountbyId(decimal Id)
        {
            BankACTypeMaster u = s.BankAccount.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllBankInformationList")]
        [HttpGet]
        public IHttpActionResult GetAllBankInformationList()
        {
            List<BankInfromationMaster> u = s.ManageBank.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetBankInformationbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetBankInformationbyId(decimal Id)
        {
            BankInfromationMaster u = s.ManageBank.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllGenderList")]
        [HttpGet]
        public IHttpActionResult GetAllGenderList()
        {
            List<GenderMaster> u = s.Gender.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetGenderbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetGenderbyId(decimal Id)
        {
            YearMaster u = s.ManageYear.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllHonoroficList")]
        [HttpGet]
        public IHttpActionResult GetAllHonoroficList()
        {
            List<HonorificMaster> u = s.Honorofic.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetHonoroficbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetHonoroficbyId(decimal Id)
        {
            HonorificMaster u = s.Honorofic.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllCompanyDocList")]
        [HttpGet]
        public IHttpActionResult GetAllCompanyDocList()
        {
            List<CompanyDocumentTypeMaster> u = s.CompanyDocumentGroup.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetCompanyDocbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetCompanyDocbyId(decimal Id)
        {
            CompanyDocumentTypeMaster u = s.CompanyDocumentGroup.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllServiceGroupList")]
        [HttpGet]
        public IHttpActionResult GetAllServiceGroupList()
        {
            List<ServiceGroupMaster> u = s.ServiceGroup.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetServiceGroupbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetServiceGroupbyId(decimal Id)
        {
            ServiceGroupMaster u = s.ServiceGroup.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllDepartmentList")]
        [HttpGet]
        public IHttpActionResult GetAllDepartmentList()
        {
            List<DepartmentMaster> u = s.Department.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetDepartmentbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetDepartmentbyId(decimal Id)
        {
            DepartmentMaster u = s.Department.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllEmployeeList")]
        [HttpGet]
        public IHttpActionResult GetAllEmployeeList()
        {
            List<EmployeeMaster> u = s.ManageEmployeeMaster.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetEmployeebyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetEmployeebyId(decimal Id)
        {
            EmployeeMaster u = s.ManageEmployeeMaster.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllCustomerList")]
        [HttpGet]
        public IHttpActionResult GetAllCustomerList()
        {
            List<CustomerMaster> u = s.ManageCustomer.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetCustomerbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetCustomerbyId(decimal Id)
        {
            CustomerMaster u = s.ManageCustomer.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }



        [Route("GetAllVendorList")]
        [HttpGet]
        public IHttpActionResult GetAllVendorList()
        {
            List<VendorMaster> u = s.ManageVender.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetVendorbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetVendorbyId(decimal Id)
        {
            VendorMaster u = s.ManageVender.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }




        [Route("GetAllLanguageList")]
        [HttpGet]
        public IHttpActionResult GetAllLanguageList()
        {
            List<LanguageMaster> u = s.ManageLanguage.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetLanguagebyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetLanguagebyId(decimal Id)
        {
            LanguageMaster u = s.ManageLanguage.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllSkillList")]
        [HttpGet]
        public IHttpActionResult GetAllSkillList()
        {
            List<EmployeeSkillMaster> u = s.ManageSkill.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetSkillbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetSkillbyId(decimal Id)
        {
            EmployeeSkillMaster u = s.ManageSkill.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllTechnologyList")]
        [HttpGet]
        public IHttpActionResult GetAllTechnologyList()
        {
            List<TechnologyMaster> u = s.ManageTechnology.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetTechnologybyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetTechnologybyId(decimal Id)
        {
            TechnologyMaster u = s.ManageTechnology.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllCountryList")]
        [HttpGet]
        public IHttpActionResult GetAllCountryList()
        {
            List<CountryMaster> u = s.Country.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetStateListByCountryId/{CountryId}")]
        [HttpGet]
        public IHttpActionResult GetStateListByCountryId([FromUri] int CountryId)
        {
            List<StateMaster> u = s.State.GetStateListByCountryId(CountryId);

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetCityListByStateId/{StateId}")]
        [HttpGet]
        public IHttpActionResult GetCityListByStateId([FromUri] int StateId)
        {
            List<CityMaster> u = s.City.GetCityListByStateId(StateId);

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetCountrybyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetCountrybyId(decimal Id)
        {
            CountryMaster u = s.Country.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetStatebyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetStatebyId(decimal Id)
        {
            StateMaster u = s.State.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetCitybyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetCitybyId(decimal Id)
        {
            CityMaster u = s.City.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllAchievementList")]
        [HttpGet]
        public IHttpActionResult GetAllAchievementList()
        {
            List<AchievementMaster> u = s.Achievement.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetAchievementbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetAchievementbyId(decimal Id)
        {
            AchievementMaster u = s.Achievement.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllBloodGroupList")]
        [HttpGet]
        public IHttpActionResult GetAllBloodGroupList()
        {
            List<BloodGroupMaster> u = s.BloodGroup.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetBloodGroupbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetBloodGroupbyId(decimal Id)
        {
            BloodGroupMaster u = s.BloodGroup.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllCampaignList")]
        [HttpGet]
        public IHttpActionResult GetAllCampaignList()
        {
            List<CampaignMaster> u = s.Campaign.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetCampaignbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetCampaignbyId(decimal Id)
        {
            CampaignMaster u = s.Campaign.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllClientList")]
        [HttpGet]
        public IHttpActionResult GetAllClientList()
        {
            List<ClientMaster> u = s.Client.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetClientbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetClientbyId(decimal Id)
        {
            ClientMaster u = s.Client.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllCompanyMasterList")]
        [HttpGet]
        public IHttpActionResult GetAllCompanyMasterList()
        {
            List<CompanyMaster> u = s.CompanyMaster.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetCompanyMasterbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetCompanyMasterbyId(decimal Id)
        {
            CompanyMaster u = s.CompanyMaster.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllContactList")]
        [HttpGet]
        public IHttpActionResult GetAllContactList()
        {
            List<ContactMaster> u = s.Contact.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetContactbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetContactbyId(decimal Id)
        {
            ContactMaster u = s.Contact.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllHolidaysList")]
        [HttpGet]
        public IHttpActionResult GetAllHolidaysList()
        {
            List<HolidayMaster> u = s.Holidays.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetHolidaysbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetHolidaysbyId(decimal Id)
        {
            HolidayMaster u = s.Holidays.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllIndustrySectorList")]
        [HttpGet]
        public IHttpActionResult GetAllIndustrySectorList()
        {
            List<IndustrySectorMaster> u = s.IndustrySector.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetIndustrySectorbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetIndustrySectorbyId(decimal Id)
        {
            IndustrySectorMaster u = s.IndustrySector.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllLeadMasterList")]
        [HttpGet]
        public IHttpActionResult GetAllLeadMasterList()
        {
            List<LeadMaster> u = s.LeadMaster.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetLeadMasterbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetLeadMasterbyId(decimal Id)
        {
            LeadMaster u = s.LeadMaster.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllLeadHistoryList")]
        [HttpGet]
        public IHttpActionResult GetAllLeadHistoryList()
        {
            List<LeadHistoryMaster> u = s.LeadHistory.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetLeadHistorybyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetLeadHistorybyId(decimal Id)
        {
            LeadHistoryMaster u = s.LeadHistory.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllLeadTypeList")]
        [HttpGet]
        public IHttpActionResult GetAllLeadTypeList()
        {
            List<LeadTypeMaster> u = s.LeadType.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetLeadTypebyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetLeadTypebyId(decimal Id)
        {
            LeadTypeMaster u = s.LeadType.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllLeaveAddonList")]
        [HttpGet]
        public IHttpActionResult GetAllLeaveAddonList()
        {
            List<LeaveAddonMaster> u = s.LeaveAddon.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetLeaveAddonbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetLeaveAddonbyId(decimal Id)
        {
            LeaveAddonMaster u = s.LeaveAddon.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllLeaveMasterList")]
        [HttpGet]
        public IHttpActionResult GetAllLeaveMasterList()
        {
            List<LeaveMaster> u = s.LeaveMaster.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetLeaveMasterbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetLeaveMasterbyId(decimal Id)
        {
            LeaveMaster u = s.LeaveMaster.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllLeaveParameterList")]
        [HttpGet]
        public IHttpActionResult GetAllLeaveParameterList()
        {
            List<LeaveParameterMaster> u = s.LeaveParameter.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetLeaveParameterbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetLeaveParameterbyId(decimal Id)
        {
            LeaveParameterMaster u = s.LeaveParameter.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllNoticeBoardList")]
        [HttpGet]
        public IHttpActionResult GetAllNoticeBoardList()
        {
            List<NoticeBoardMaster> u = s.NoticeBoard.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetNoticeBoardbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetNoticeBoardbyId(decimal Id)
        {
            NoticeBoardMaster u = s.NoticeBoard.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllOrderList")]
        [HttpGet]
        public IHttpActionResult GetAllOrderList()
        {
            List<OrderMaster> u = s.Order.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetOrderbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetOrderbyId(decimal Id)
        {
            OrderMaster u = s.Order.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllPriorityList")]
        [HttpGet]
        public IHttpActionResult GetAllPriorityList()
        {
            List<PriorityMaster> u = s.Priority.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetPrioritybyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetPrioritybyId(decimal Id)
        {
            PriorityMaster u = s.Priority.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllProjectList")]
        [HttpGet]
        public IHttpActionResult GetAllProjectList()
        {
            List<ProjectMaster> u = s.Project.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetProjectbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetProjectbyId(decimal Id)
        {
            ProjectMaster u = s.Project.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllProjectMeetingList")]
        [HttpGet]
        public IHttpActionResult GetAllProjectMeetingList()
        {
            List<ProjectMeetingMaster> u = s.ProjectMeeting.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetProjectMeetingbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetProjectMeetingbyId(decimal Id)
        {
            ProjectMeetingMaster u = s.ProjectMeeting.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllProjectPhaseList")]
        [HttpGet]
        public IHttpActionResult GetAllProjectPhaseList()
        {
            List<ProjectPhaseMaster> u = s.ProjectPhase.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetProjectPhasebyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetProjectPhasebyId(decimal Id)
        {
            ProjectPhaseMaster u = s.ProjectPhase.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllPunchDataList")]
        [HttpGet]
        public IHttpActionResult GetAllPunchDataList()
        {
            List<PunchDataMaster> u = s.PunchData.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetPunchDatabyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetPunchDatabyId(decimal Id)
        {
            PunchDataMaster u = s.PunchData.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllShiftMasterList")]
        [HttpGet]
        public IHttpActionResult GetAllShiftMasterList()
        {
            List<ShiftMaster> u = s.ShiftMaster.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetShiftMasterbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetShiftMasterbyId(decimal Id)
        {
            ShiftMaster u = s.ShiftMaster.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllStarList")]
        [HttpGet]
        public IHttpActionResult GetAllStarList()
        {
            List<StarMaster> u = s.Star.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetStarbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetStarbyId(decimal Id)
        {
            StarMaster u = s.Star.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllStarAssignList")]
        [HttpGet]
        public IHttpActionResult GetAllStarAssignList()
        {
            List<StarAssignMaster> u = s.StarAssign.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetStarAssignbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetStarAssignbyId(decimal Id)
        {
            StarAssignMaster u = s.StarAssign.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


        [Route("GetAllWorklistList")]
        [HttpGet]
        public IHttpActionResult GetAllWorklistList()
        {
            List<WorklistMaster> u = s.Worklist.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetWorklistbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetWorklistbyId(decimal Id)
        {
            WorklistMaster u = s.Worklist.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }



        [Route("GetAllStatusList")]
        [HttpGet]
        public IHttpActionResult GetAllStatusList()
        {
            List<StatusMaster> u = s.Status.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetStatusbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetStatusbyId(decimal Id)
        {
            StatusMaster u = s.Status.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }



        [Route("GetAllMonthList")]
        [HttpGet]
        public IHttpActionResult GetAllMonthList()
        {
            List<MonthMaster> u = s.Month.Get().Where(c => c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }

        [Route("GetMonthbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetMonthbyId(decimal Id)
        {
            MonthMaster u = s.Month.Get((int)Id);
            ResponseBody RB = new ResponseBody();
            if (u != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = u;
                return Ok(RB);
            }
            else
            {
                RB.success = false;
                RB.msg = "No Data Available !";
                RB.data = "";
                return Ok(RB);
            }

        }


    }
}
