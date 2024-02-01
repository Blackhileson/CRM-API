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

namespace CRM.Controllers
{
    [RoutePrefix("api/Service")]
    public class ServiceController : ApiController
    {
        string BaseURL = System.Configuration.ConfigurationManager.AppSettings["AdminBaseURI"];
        Service s;

        public ServiceController()
        {
            s = new Service();
        }


        [Route("GetDomainRegistrationList")]
        [HttpGet]
        public IHttpActionResult GetDomainRegistrationList()
        {
            List<DomainRegistrationMaster> u = s.DomainRegistration.Get().Where(c => c.IsRecordActive == true).ToList();

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

        [Route("GetDomainRegistrationbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetDomainRegistrationbyId(decimal Id)
        {
            DomainRegistrationMaster u = s.DomainRegistration.Get((int)Id);
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


        [Route("GetWebHostingList")]
        [HttpGet]
        public IHttpActionResult GetWebHostingList()
        {
            List<WebHosting> u = s.WebHosting.Get().Where(c => c.IsRecordActive == true).ToList();

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

        [Route("GetWebHostingbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetWebHostingbyId(decimal Id)
        {
            WebHosting u = s.WebHosting.Get((int)Id);
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


        [Route("GetEmailAccountList")]
        [HttpGet]
        public IHttpActionResult GetEmailAccountList()
        {
            List<EmailAccountMaster> u = s.EmailAccount.Get().Where(c => c.IsRecordActive == true).ToList();

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

        [Route("GetEmailAccountbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetEmailAccountbyId(decimal Id)
        {
            EmailAccountMaster u = s.EmailAccount.Get((int)Id);
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


        [Route("GetSEOSubmissionList")]
        [HttpGet]
        public IHttpActionResult GetSEOSubmissionList()
        {
            List<SEOSubmissionMaster> u = s.SEOSubmission.Get().Where(c => c.IsRecordActive == true).ToList();

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

        [Route("GetSEOSubmissionbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetSEOSubmissionbyId(decimal Id)
        {
            SEOSubmissionMaster u = s.SEOSubmission.Get((int)Id);
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



        [Route("GetWebsiteDesigningList")]
        [HttpGet]
        public IHttpActionResult GetWebsiteDesigningList()
        {
            List<WebDesignMaster> u = s.WebsiteDesigning.Get().Where(c => c.IsRecordActive == true).ToList();

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

        [Route("GetWebsiteDesigningbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetWebsiteDesigningbyId(decimal Id)
        {
            WebDesignMaster u = s.WebsiteDesigning.Get((int)Id);
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


        [Route("GetWebsiteApplicationList")]
        [HttpGet]
        public IHttpActionResult GetWebsiteApplicationList()
        {
            List<WebApplicationMaster> u = s.WebApplication.Get().Where(c => c.IsRecordActive == true).ToList();

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

        [Route("GetWebsiteApplicationbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetWebsiteApplicationbyId(decimal Id)
        {
            WebApplicationMaster u = s.WebApplication.Get((int)Id);
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


        [Route("GetSoftwareDevelopmentList")]
        [HttpGet]
        public IHttpActionResult GetSoftwareDevelopmentList()
        {
            List<SoftwareDevelopmentMaster> u = s.SoftwareDevelopment.Get().Where(c => c.IsRecordActive == true).ToList();

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

        [Route("GetSoftwareDevelopmentbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetSoftwareDevelopmentbyId(decimal Id)
        {
            SoftwareDevelopmentMaster u = s.SoftwareDevelopment.Get((int)Id);
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



        [Route("GetMobileApplicationList")]
        [HttpGet]
        public IHttpActionResult GetMobileApplicationList()
        {
            List<MobileApplication> u = s.MobileApplication.Get().Where(c => c.IsRecordActive == true).ToList();

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

        [Route("GetMobileApplicationbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetMobileApplicationbyId(decimal Id)
        {
            MobileApplication u = s.MobileApplication.Get((int)Id);
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


        [Route("GetCorporateBrandingList")]
        [HttpGet]
        public IHttpActionResult GetCorporateBrandingList()
        {
            List<CorporateBrandingMaster> u = s.CorporateBranding.Get().Where(c => c.IsRecordActive == true).ToList();

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

        [Route("GetCorporateBrandingbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetCorporateBrandingbyId(decimal Id)
        {
            CorporateBrandingMaster u = s.CorporateBranding.Get((int)Id);
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



        [Route("GetSSLCertificateList")]
        [HttpGet]
        public IHttpActionResult GetSSLCertificateList()
        {
            List<SSLCertificate> u = s.SSLCertificate.Get().Where(c => c.IsRecordActive == true).ToList();

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

        [Route("GetSSLCertificatebyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetSSLCertificatebyId(decimal Id)
        {
            SSLCertificate u = s.SSLCertificate.Get((int)Id);
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



        [Route("GetServicePasswordList")]
        [HttpGet]
        public IHttpActionResult GetServicePasswordList()
        {
            List<ServicePassword> u = s.ServicePassword.Get().Where(c => c.IsRecordActive == true).ToList();

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

        [Route("GetServicePasswordbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetServicePasswordbyId(decimal Id)
        {
            ServicePassword u = s.ServicePassword.Get((int)Id);
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


        [Route("GetSMMSubmissionList")]
        [HttpGet]
        public IHttpActionResult GetSMMSubmissionList()
        {
            List<SMMSubmission> u = s.SMMSubmission.Get().Where(c => c.IsRecordActive == true).ToList();

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

        [Route("GetSMMSubmissionbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetSMMSubmissionbyId(decimal Id)
        {
            SMMSubmission u = s.SMMSubmission.Get((int)Id);
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


        [Route("GetERPImplementationList")]
        [HttpGet]
        public IHttpActionResult GetERPImplementationList()
        {
            List<ERPImplemetationMaster> u = s.ERPImplementataion.Get().Where(c => c.IsRecordActive == true).ToList();

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

        [Route("GetERPImplementationbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetERPImplementationbyId(decimal Id)
        {
            ERPImplemetationMaster u = s.ERPImplementataion.Get((int)Id);
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
