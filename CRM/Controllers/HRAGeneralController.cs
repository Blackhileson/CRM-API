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
    [RoutePrefix("api/HRAGeneral")]
    public class HRAGeneralController : ApiController
    {

        string BaseURL = System.Configuration.ConfigurationManager.AppSettings["AdminBaseURI"];
        Service s;

        public HRAGeneralController()
        {
            s = new Service();
        }


        [Route("AddStarDetails")]
        [HttpPost]
        public IHttpActionResult AddStarDetails([FromBody] StarModel e)
        {

            ResponseBody RB = new ResponseBody();
            int employeeID = Convert.ToInt32(e.employeeId);
            EmployeeMaster emp = s.ManageEmployeeMaster.Get(employeeID);


            if (e.StarId == 0)
            {

                StarMaster o = new StarMaster();

                o.Starname = e.Starname;
                o.StarImgURL = e.Image;
                o.IsAddedBy = emp.EmployeeID;
                o.IsAddedOn = DateTime.Now;
                o.IsActive = true;
                o.IsDisplay = true;

                StarMaster pm = s.Star.Add(o);

                RB.success = true;
                RB.msg = "Star Details Added!";
                RB.data = pm.StarId;
                return Ok(RB);
            }

            else
            {
                return NotFound();
            }


        }


        [Route("UpdateStarDetails")]
        [HttpPost]
        public IHttpActionResult UpdateStarDetails(StarModel e)
        {
            int employeeID = Convert.ToInt32(e.employeeId);
            EmployeeMaster emp = s.ManageEmployeeMaster.Get(employeeID);

            StarMaster e1 = s.Star.GetStarById((int)e.StarId);

            e1.Starname = e.Starname;
            e1.StarImgURL = e.Image;
            e1.IsAddedBy = emp.EmployeeID;
            e1.IsAddedOn = DateTime.Now;
            e1.IsActive = true;
            e1.IsDisplay = true;

            s.Star.Update(e1);
            ResponseBody RB = new ResponseBody();
            if (e1 != null)
            {
                RB.success = true;
                RB.msg = "Details Updated Successfully";
                RB.data = e1.StarId;
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


        [Route("DeleteStarbyId/{Id}")]
        [HttpPost]
        public IHttpActionResult DeleteStarbyId([FromUri]  int Id)
        {

            StarMaster obj = s.Star.Get(Id);
            obj.IsActive = false;
            obj.IsDisplay = false;
            obj.IsDeletedOn = DateTime.Now;
            s.Star.Update(obj);
            ResponseBody RB = new ResponseBody();

            RB.success = true;
            RB.msg = "Star Deleted Successfully";
            RB.data = "";
            return Ok(RB);
        }


        [Route("AddAssignStarDetails")]
        [HttpPost]
        public IHttpActionResult AddAssignStarDetails([FromBody] AssignStarModel e)
        {

            ResponseBody RB = new ResponseBody();
            int employeeID = Convert.ToInt32(e.employeeId);
            EmployeeMaster emp = s.ManageEmployeeMaster.Get(employeeID);


            if (e.StarAssignId == 0)
            {

                StarAssignMaster o = new StarAssignMaster();

                o.GetEmployeeId = e.GetEmployeeId;
                o.GetEmployeeName = e.GetEmployeeName;
                o.AssignDate = e.AssignDate;
                o.Month = e.Month;
                o.StarId = e.StarId;
                o.StarName = e.StarName;
                o.StarImgURL = e.StarImgURL;
                o.GivenByEmployeeId = e.GivenByEmployeeId;
                o.GivenByEmployeeName = e.GivenByEmployeeName;
                o.Note = e.Note;
                o.IsAddedBy = emp.EmployeeID;
                o.IsAddedOn = DateTime.Now;
                o.IsActive = true;
                o.IsDisplay = true;

                StarAssignMaster pm = s.StarAssign.Add(o);

                RB.success = true;
                RB.msg = "Assign Star Details Added!";
                RB.data = pm.StarAssignId;
                return Ok(RB);
            }

            else
            {
                return NotFound();
            }


        }


        [Route("UpdateAssignStarDetails")]
        [HttpPost]
        public IHttpActionResult UpdateAssignStarDetails(AssignStarModel e)
        {
            int employeeID = Convert.ToInt32(e.employeeId);
            EmployeeMaster emp = s.ManageEmployeeMaster.Get(employeeID);

            StarAssignMaster e1 = s.StarAssign.GetAssignstarById((int)e.StarAssignId);

            e1.GetEmployeeId = e.GetEmployeeId;
            e1.GetEmployeeName = e.GetEmployeeName;
            e1.AssignDate = e.AssignDate;
            e1.Month = e.Month;
            e1.StarId = e.StarId;
            e1.StarName = e.StarName;
            e1.StarImgURL = e.StarImgURL;
            e1.GivenByEmployeeId = e.GivenByEmployeeId;
            e1.GivenByEmployeeName = e.GivenByEmployeeName;
            e1.Note = e.Note;
            e1.IsAddedBy = emp.EmployeeID;
            e1.IsAddedOn = DateTime.Now;
            e1.IsActive = true;
            e1.IsDisplay = true;

            s.StarAssign.Update(e1);
            ResponseBody RB = new ResponseBody();
            if (e1 != null)
            {
                RB.success = true;
                RB.msg = "Details Updated Successfully";
                RB.data = e1.StarAssignId;
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


        [Route("DeleteAssignStarbyId/{Id}")]
        [HttpPost]
        public IHttpActionResult DeleteAssignStarbyId([FromUri]  int Id)
        {

            StarAssignMaster obj = s.StarAssign.Get(Id);
            obj.IsActive = false;
            obj.IsDisplay = false;
            obj.IsDeletedOn = DateTime.Now;
            s.StarAssign.Update(obj);
            ResponseBody RB = new ResponseBody();

            RB.success = true;
            RB.msg = "Assigned Star Deleted Successfully";
            RB.data = "";
            return Ok(RB);
        }


        [Route("GetMyStarsById/{Id}")]
        [HttpGet]
        public IHttpActionResult GetStateListByCountryId([FromUri] int Id)
        {
            List<StarAssignMaster> u = s.StarAssign.GetMyStarById(Id);

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


        [Route("AddAchievementDetails")]
        [HttpPost]
        public IHttpActionResult AddAchievementDetails([FromBody] AchievementModel e)
        {

            ResponseBody RB = new ResponseBody();
            int employeeID = Convert.ToInt32(e.employeeId);
            EmployeeMaster emp = s.ManageEmployeeMaster.Get(employeeID);


            if (e.AchivementId == 0)
            {

                AchievementMaster o = new AchievementMaster();

                o.GetEmployeeId = e.GetEmployeeId;
                o.GetEmployeeName = e.GetEmployeeName;
                o.ProjectId = e.ProjectId;
                o.ProjectName = e.ProjectName;
                o.ReasonOfAppreciation = e.ReasonOfAppreciation;
                o.IsAddedBy = emp.EmployeeID;
                o.IsAddedOn = DateTime.Now;
                o.IsActive = true;
                o.IsDisplay = true;

                AchievementMaster pm = s.Achievement.Add(o);

                RB.success = true;
                RB.msg = "Achievement Details Added!";
                RB.data = pm.AchivementId;
                return Ok(RB);
            }

            else
            {
                return NotFound();
            }


        }


        [Route("UpdateAchievementDetails")]
        [HttpPost]
        public IHttpActionResult UpdateAchievementDetails(AchievementModel e)
        {
            int employeeID = Convert.ToInt32(e.employeeId);
            EmployeeMaster emp = s.ManageEmployeeMaster.Get(employeeID);

            AchievementMaster e1 = s.Achievement.GetAchivementById((int)e.AchivementId);

            e1.GetEmployeeId = e.GetEmployeeId;
            e1.GetEmployeeName = e.GetEmployeeName;
            e1.ProjectId = e.ProjectId;
            e1.ProjectName = e.ProjectName;
            e1.ReasonOfAppreciation = e.ReasonOfAppreciation;
            e1.IsAddedBy = emp.EmployeeID;
            e1.IsAddedOn = DateTime.Now;
            e1.IsActive = true;
            e1.IsDisplay = true;

            s.Achievement.Update(e1);
            ResponseBody RB = new ResponseBody();
            if (e1 != null)
            {
                RB.success = true;
                RB.msg = "Details Updated Successfully";
                RB.data = e1.AchivementId;
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


        [Route("DeleteAchievementbyId/{Id}")]
        [HttpPost]
        public IHttpActionResult DeleteAchievementbyId([FromUri]  int Id)
        {

            AchievementMaster obj = s.Achievement.Get(Id);
            obj.IsActive = false;
            obj.IsDisplay = false;
            obj.IsDeletedOn = DateTime.Now;
            s.Achievement.Update(obj);
            ResponseBody RB = new ResponseBody();

            RB.success = true;
            RB.msg = "Achievement Deleted Successfully";
            RB.data = "";
            return Ok(RB);
        }


        [Route("AddHolidaysDetails")]
        [HttpPost]
        public IHttpActionResult AddHolidaysDetails([FromBody] HolidaysModel e)
        {

            ResponseBody RB = new ResponseBody();
            int employeeID = Convert.ToInt32(e.employeeId);
            EmployeeMaster emp = s.ManageEmployeeMaster.Get(employeeID);


            if (e.HolidayId == 0)
            {

                HolidayMaster o = new HolidayMaster();

                o.HolidayName = e.HolidayName;
                o.LeaveParameterId = e.LeaveParameterId;
                o.LeaveParameterName = e.LeaveParameterName;
                o.HolidayDate = e.HolidayDate;
                o.IsAddedBy = emp.EmployeeID;
                o.IsAddedOn = DateTime.Now;
                o.IsActive = true;
                o.IsDisplay = true;

                HolidayMaster pm = s.Holidays.Add(o);

                RB.success = true;
                RB.msg = "Holiday Details Added!";
                RB.data = pm.HolidayId;
                return Ok(RB);
            }

            else
            {
                return NotFound();
            }


        }


        [Route("UpdateHolidayDetails")]
        [HttpPost]
        public IHttpActionResult UpdateHolidayDetails(HolidaysModel e)
        {
            int employeeID = Convert.ToInt32(e.employeeId);
            EmployeeMaster emp = s.ManageEmployeeMaster.Get(employeeID);

            HolidayMaster e1 = s.Holidays.GetHolidayById((int)e.HolidayId);

            e1.HolidayName = e.HolidayName;
            e1.LeaveParameterId = e.LeaveParameterId;
            e1.LeaveParameterName = e.LeaveParameterName;
            e1.HolidayDate = e.HolidayDate;
            e1.IsAddedBy = emp.EmployeeID;
            e1.IsAddedOn = DateTime.Now;
            e1.IsActive = true;
            e1.IsDisplay = true;

            s.Holidays.Update(e1);
            ResponseBody RB = new ResponseBody();
            if (e1 != null)
            {
                RB.success = true;
                RB.msg = "Details Updated Successfully";
                RB.data = e1.HolidayId;
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


        [Route("DeletHolidaysbyId/{Id}")]
        [HttpPost]
        public IHttpActionResult DeletHolidaysbyId([FromUri]  int Id)
        {

            HolidayMaster obj = s.Holidays.Get(Id);
            obj.IsActive = false;
            obj.IsDisplay = false;
            obj.IsDeletedOn = DateTime.Now;
            s.Holidays.Update(obj);
            ResponseBody RB = new ResponseBody();

            RB.success = true;
            RB.msg = "Holiday Deleted Successfully";
            RB.data = "";
            return Ok(RB);
        }


        [Route("AddNoticeDetails")]
        [HttpPost]
        public IHttpActionResult AddNoticeDetails([FromBody] List<NoticeBoardModel> noticeBoardModels)
        {

            ResponseBody RB = new ResponseBody();

            foreach (NoticeBoardModel e in noticeBoardModels)
            {

                int employeeID = Convert.ToInt32(e.employeeId);
                EmployeeMaster emp = s.ManageEmployeeMaster.Get(employeeID);


                if (e.NoticeBoardId == 0)
                {

                    NoticeBoardMaster o = new NoticeBoardMaster();

                    o.NoticeTitle = e.NoticeTitle;
                    o.NoticeDate = e.NoticeDate;
                    o.DocumentUrl = e.DocumentUrl;
                    o.IsToAllEmployee = e.IsToAllEmployee;
                    o.EmployeeName = e.EmployeeName;
                    o.Description = e.Description;
                    o.IsAddedBy = emp.EmployeeID;
                    o.IsAddedOn = DateTime.Now;
                    o.IsActive = true;
                    o.IsDisplay = true;

                    NoticeBoardMaster pm = s.NoticeBoard.Add(o);

                }

                else
                {
                    return NotFound();
                }
            }

            RB.success = true;
            RB.msg = "Notice Details Added!";
            RB.data = noticeBoardModels.Select(e => e.NoticeBoardId).ToList();
            return Ok(RB);

        }


        [Route("UpdateNoticeDetails")]
        [HttpPost]
        public IHttpActionResult UpdateNoticeDetails(List<NoticeBoardModel> noticeBoardModels)
        {
            ResponseBody RB = new ResponseBody();

            foreach (NoticeBoardModel e in noticeBoardModels)
            {
                int employeeID = Convert.ToInt32(e.employeeId);
                EmployeeMaster emp = s.ManageEmployeeMaster.Get(employeeID);

                NoticeBoardMaster e1 = s.NoticeBoard.GetNoticeById((int)e.NoticeBoardId);

                if (e1 != null)
                {
                    e1.NoticeTitle = e.NoticeTitle;
                    e1.NoticeDate = e.NoticeDate;
                    e1.DocumentUrl = e.DocumentUrl;
                    e1.IsToAllEmployee = e.IsToAllEmployee;
                    e1.EmployeeName = e.EmployeeName;
                    e1.Description = e.Description;
                    e1.IsAddedBy = emp.EmployeeID;
                    e1.IsAddedOn = DateTime.Now;
                    e1.IsActive = true;
                    e1.IsDisplay = true;

                    s.NoticeBoard.Update(e1);
                }
                else
                {
                    RB.success = false;
                    RB.msg = "Notice not found for NoticeBoardId: " + e.NoticeBoardId;
                    RB.data = null;
                    return Ok(RB);
                }
            }

            RB.success = true;
            RB.msg = "Details Updated Successfully";
            RB.data = noticeBoardModels.Select(e => e.NoticeBoardId).ToList();
            return Ok(RB);
        }


        [Route("DeleteNoticebyId/{Id}")]
        [HttpPost]
        public IHttpActionResult DeleteNoticebyId([FromUri]  int Id)
        {

            NoticeBoardMaster obj = s.NoticeBoard.Get(Id);
            obj.IsActive = false;
            obj.IsDisplay = false;
            obj.IsDeletedOn = DateTime.Now;
            s.NoticeBoard.Update(obj);
            ResponseBody RB = new ResponseBody();

            RB.success = true;
            RB.msg = "Notice Deleted Successfully";
            RB.data = "";
            return Ok(RB);
        }



        [Route("GetAllEmployeeDocList/{Id}")]
        [HttpGet]
        public IHttpActionResult GetAllEmployeeDocList(decimal Id)
        {
            List<ManageEmployeeDocumentMaster> u = s.ManageEmployeeDoc.Get().Where(c =>c.EmployeeID == Id && c.IsActive == true && c.IsDisplay == true).ToList();

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

        [Route("GetEmployeeDocbyId/{Id}")]
        [HttpGet]
        public IHttpActionResult GetEmployeeDocbyId(decimal Id)
        {
            ManageEmployeeDocumentMaster u = s.ManageEmployeeDoc.Get((int)Id);
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


        [Route("AddEmployeeDocDetails")]
        [HttpPost]
        public IHttpActionResult AddEmployeeDocDetails([FromBody] EmployeeDocumentModel e)
        {

            ResponseBody RB = new ResponseBody();
            int employeeID = Convert.ToInt32(e.employeeId);
            EmployeeMaster emp = s.ManageEmployeeMaster.Get(employeeID);


            if (e.EmployeeDocumentID == 0)
            {

                ManageEmployeeDocumentMaster o = new ManageEmployeeDocumentMaster();

                o.EmployeeID = e.EmployeeID;
                o.EmployeeName = e.EmployeeName;
                o.DocumentTypeID = e.DocumentTypeID;
                o.DocumentTypeName = e.DocumentTypeName;
                o.FileUpload = e.FileUpload;
                o.IsAddedBy = emp.EmployeeID;
                o.IsAddedOn = DateTime.Now;
                o.IsActive = true;
                o.IsDisplay = true;

                ManageEmployeeDocumentMaster pm = s.ManageEmployeeDoc.Add(o);

                RB.success = true;
                RB.msg = "Document Details Added!";
                RB.data = pm.EmployeeDocumentID;
                return Ok(RB);
            }

            else
            {
                return NotFound();
            }


        }


        [Route("UpdateEmployeeDocDetails")]
        [HttpPost]
        public IHttpActionResult UpdateEmployeeDocDetails(EmployeeDocumentModel e)
        {
            int employeeID = Convert.ToInt32(e.employeeId);
            EmployeeMaster emp = s.ManageEmployeeMaster.Get(employeeID);

            ManageEmployeeDocumentMaster e1 = s.ManageEmployeeDoc.GetEmpDocById((int)e.EmployeeDocumentID);

            e1.EmployeeID = e.EmployeeID;
            e1.EmployeeName = e.EmployeeName;
            e1.DocumentTypeID = e.DocumentTypeID;
            e1.DocumentTypeName = e.DocumentTypeName;
            e1.FileUpload = e.FileUpload;
            e1.IsAddedBy = emp.EmployeeID;
            e1.IsAddedOn = DateTime.Now;
            e1.IsActive = true;
            e1.IsDisplay = true;

            s.ManageEmployeeDoc.Update(e1);
            ResponseBody RB = new ResponseBody();
            if (e1 != null)
            {
                RB.success = true;
                RB.msg = "Details Updated Successfully";
                RB.data = e1.EmployeeDocumentID;
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


        [Route("DeleteEmplyoeeDoc/{Id}")]
        [HttpPost]
        public IHttpActionResult DeleteEmplyoeeDoc([FromUri]  int Id)
        {

            ManageEmployeeDocumentMaster obj = s.ManageEmployeeDoc.Get(Id);
            obj.IsActive = false;
            obj.IsDisplay = false;
            obj.IsDeletedOn = DateTime.Now;
            s.ManageEmployeeDoc.Update(obj);
            ResponseBody RB = new ResponseBody();

            RB.success = true;
            RB.msg = "Document Deleted Successfully";
            RB.data = "";
            return Ok(RB);
        }





    }
}
