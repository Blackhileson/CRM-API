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
    [RoutePrefix("api/Project")]
    public class ProjectController : ApiController
    {

        string BaseURL = System.Configuration.ConfigurationManager.AppSettings["AdminBaseURI"];
        Service s;

        public ProjectController()
        {
            s = new Service();
        }


        [Route("AddProjectDetails")]
        [HttpPost]
        public IHttpActionResult AddProjectDetails([FromBody] ProjectModel e)
        {

            ResponseBody RB = new ResponseBody();
            int employeeID = Convert.ToInt32(e.employeeId);
            EmployeeMaster emp = s.ManageEmployeeMaster.Get(employeeID);


            if (e.ProjectID == 0)
            {

                ProjectMaster o = new ProjectMaster();

                o.CompanyID = e.CompanyID;
                o.CompanyName = e.CompanyName;
                o.ServiceGroupID = e.ServiceGroupID;
                o.ServiceGroupName = e.ServiceGroupName;
                o.CustomerID = e.CustomerID;
                o.CustomerName = e.CustomerName;
                o.ProjectLeaderId = e.ProjectLeaderId;
                o.ProjectLeaderName = e.ProjectLeaderName;
                o.ProjectName = e.ProjectName;
                o.ExpectedStartDate = e.ExpectedStartDate;
                o.ActualStartDate = e.ActualStartDate;
                o.ExpectedEndDate = e.ExpectedEndDate;
                o.Langauge = e.Langauge;
                o.TechnologyId = e.TechnologyId;
                o.TechnologyName = e.TechnologyName;
                o.Hardware = e.Hardware;
                o.Skill = e.Skill;
                o.ProjectStatus = e.ProjectStatus;
                o.ProjectMangerID = e.ProjectMangerID;
                o.ProjectManagerName = e.ProjectManagerName;
                o.Description = e.Description;
                o.IsMultiPhase = e.IsMultiPhase;
                o.IsAddedBy = Convert.ToString(emp.EmployeeID);
                o.IsAddedOn = DateTime.Now;
                o.IsActive = true;
                o.IsDisplay = true;

                ProjectMaster pm = s.Project.Add(o);

                RB.success = true;
                RB.msg = "Project Details Added!";
                RB.data = pm.ProjectID;
                return Ok(RB);
            }

            else
            {
                return NotFound();
            }


        }


        [Route("UpdateProjectDetails")]
        [HttpPost]
        public IHttpActionResult UpdateProjectDetails(ProjectModel e)
        {
            int employeeID = Convert.ToInt32(e.employeeId);
            EmployeeMaster emp = s.ManageEmployeeMaster.Get(employeeID);

            ProjectMaster e1 = s.Project.GetProjectById((int)e.ProjectID);

            e1.CompanyID = e.CompanyID;
            e1.CompanyName = e.CompanyName;
            e1.ServiceGroupID = e.ServiceGroupID;
            e1.ServiceGroupName = e.ServiceGroupName;
            e1.CustomerID = e.CustomerID;
            e1.CustomerName = e.CustomerName;
            e1.ProjectLeaderId = e.ProjectLeaderId;
            e1.ProjectLeaderName = e.ProjectLeaderName;
            e1.ProjectName = e.ProjectName;
            e1.ExpectedStartDate = e.ExpectedStartDate;
            e1.ActualStartDate = e.ActualStartDate;
            e1.ExpectedEndDate = e.ExpectedEndDate;
            e1.Langauge = e.Langauge;
            e1.TechnologyId = e.TechnologyId;
            e1.TechnologyName = e.TechnologyName;
            e1.Hardware = e.Hardware;
            e1.Skill = e.Skill;
            e1.ProjectStatus = e.ProjectStatus;
            e1.ProjectMangerID = e.ProjectMangerID;
            e1.ProjectManagerName = e.ProjectManagerName;
            e1.Description = e.Description;
            e1.IsMultiPhase = e.IsMultiPhase;
            e1.IsAddedBy = Convert.ToString(emp.EmployeeID);
            e1.IsAddedOn = DateTime.Now;
            e1.IsActive = true;
            e1.IsDisplay = true;

            s.Project.Update(e1);
            ResponseBody RB = new ResponseBody();
            if (e1 != null)
            {
                RB.success = true;
                RB.msg = "Details Updated Successfully";
                RB.data = e1.ProjectID;
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


        [Route("DeleteProjectbyId/{Id}")]
        [HttpPost]
        public IHttpActionResult DeleteProjectbyId([FromUri]  int Id)
        {

            ProjectMaster obj = s.Project.Get(Id);
            obj.IsActive = false;
            obj.IsDisplay = false;
            obj.IsDeletedOn = DateTime.Now;
            s.Project.Update(obj);
            ResponseBody RB = new ResponseBody();

            RB.success = true;
            RB.msg = "Project Deleted Successfully";
            RB.data = "";
            return Ok(RB);
        }

        [Route("AddProjectPhaseDetails")]
        [HttpPost]
        public IHttpActionResult AddProjectPhaseDetails([FromBody] ProjectPhaseModel e)
        {

            ResponseBody RB = new ResponseBody();
            int employeeID = Convert.ToInt32(e.employeeId);
            EmployeeMaster emp = s.ManageEmployeeMaster.Get(employeeID);


            if (e.ProjectPhaseID == 0)
            {

                ProjectPhaseMaster o = new ProjectPhaseMaster();

                o.ProjectID = e.ProjectID;
                o.ProjectName = e.ProjectName;
                o.PhaseName = e.PhaseName;
                o.StartDate = e.StartDate;
                o.EndDate = e.EndDate;
                o.Hours = e.Hours;
                o.Employee = e.Employee;
                o.IsAddedBy = Convert.ToString(emp.EmployeeID);
                o.IsAddedOn = DateTime.Now;
                o.IsActive = true;
                o.IsDisplay = true;

                ProjectPhaseMaster pm = s.ProjectPhase.Add(o);

                RB.success = true;
                RB.msg = "ProjectPhase Details Added!";
                RB.data = pm.ProjectPhaseID;
                return Ok(RB);
            }

            else
            {
                return NotFound();
            }


        }


        [Route("UpdateProjectPhaseDetails")]
        [HttpPost]
        public IHttpActionResult UpdateProjectPhaseDetails(ProjectPhaseModel e)
        {
            int employeeID = Convert.ToInt32(e.employeeId);
            EmployeeMaster emp = s.ManageEmployeeMaster.Get(employeeID);

            ProjectPhaseMaster e1 = s.ProjectPhase.GetProjectphaseById((int)e.ProjectPhaseID);

            e1.ProjectID = e.ProjectID;
            e1.ProjectName = e.ProjectName;
            e1.PhaseName = e.PhaseName;
            e1.StartDate = e.StartDate;
            e1.EndDate = e.EndDate;
            e1.Hours = e.Hours;
            e1.Employee = e.Employee;
            e1.IsAddedBy = Convert.ToString(emp.EmployeeID);
            e1.IsAddedOn = DateTime.Now;
            e1.IsActive = true;
            e1.IsDisplay = true;

            s.ProjectPhase.Update(e1);
            ResponseBody RB = new ResponseBody();
            if (e1 != null)
            {
                RB.success = true;
                RB.msg = "Details Updated Successfully";
                RB.data = e1.ProjectPhaseID;
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


        [Route("DeleteProjectPhasebyId/{Id}")]
        [HttpPost]
        public IHttpActionResult DeleteProjectPhasebyId([FromUri]  int Id)
        {

            ProjectPhaseMaster obj = s.ProjectPhase.Get(Id);
            obj.IsActive = false;
            obj.IsDisplay = false;
            obj.IsDeletedOn = DateTime.Now;
            s.ProjectPhase.Update(obj);
            ResponseBody RB = new ResponseBody();

            RB.success = true;
            RB.msg = "ProjectPhase Deleted Successfully";
            RB.data = "";
            return Ok(RB);
        }


        [Route("AddWorklistDetails")]
        [HttpPost]
        public IHttpActionResult AddWorklistDetails([FromBody] WorklistModel e)
        {

            ResponseBody RB = new ResponseBody();
            int employeeID = Convert.ToInt32(e.employeeId);
            EmployeeMaster emp = s.ManageEmployeeMaster.Get(employeeID);


            if (e.WorklistID == 0)
            {

                WorklistMaster o = new WorklistMaster();

                o.ProjectID = e.ProjectID;
                o.ProjectName = e.ProjectName;
                o.ProjectPhaseID = e.ProjectPhaseID;
                o.PhaseName = e.PhaseName;
                o.WorkName = e.WorkName;
                o.WorkDescription = e.WorkDescription;
                o.ProjectStatusID = e.ProjectStatusID;
                o.ProjectStatus = e.ProjectStatus;
                o.WorkHour = e.WorkHour;
                o.IsAddedBy = emp.EmployeeID;
                o.IsAddedOn = DateTime.Now;
                o.IsActive = true;
                o.IsDisplay = true;

                WorklistMaster pm = s.Worklist.Add(o);

                RB.success = true;
                RB.msg = "Worklist Details Added!";
                RB.data = pm.WorklistID;
                return Ok(RB);
            }

            else
            {
                return NotFound();
            }


        }


        [Route("UpdateWorklistDetails")]
        [HttpPost]
        public IHttpActionResult UpdateWorklistDetails(WorklistModel e)
        {
            int employeeID = Convert.ToInt32(e.employeeId);
           EmployeeMaster emp = s.ManageEmployeeMaster.Get(employeeID);

            WorklistMaster e1 = s.Worklist.GetworklistById((int)e.WorklistID);

            e1.ProjectID = e.ProjectID;
            e1.ProjectName = e.ProjectName;
            e1.ProjectPhaseID = e.ProjectPhaseID;
            e1.PhaseName = e.PhaseName;
            e1.WorkName = e.WorkName;
            e1.WorkDescription = e.WorkDescription;
            e1.ProjectStatusID = e.ProjectStatusID;
            e1.ProjectStatus = e.ProjectStatus;
            e1.WorkHour = e.WorkHour;
            e1.IsAddedBy = emp.EmployeeID;
            e1.IsAddedOn = DateTime.Now;
            e1.IsActive = true;
            e1.IsDisplay = true;

            s.Worklist.Update(e1);
            ResponseBody RB = new ResponseBody();
            if (e1 != null)
            {
                RB.success = true;
                RB.msg = "Details Updated Successfully";
                RB.data = e1.WorklistID;
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


        [Route("DeleteWorklistbyId/{Id}")]
        [HttpPost]
        public IHttpActionResult DeleteWorklistbyId([FromUri]  int Id)
        {

            WorklistMaster obj = s.Worklist.Get(Id);
            obj.IsActive = false;
            obj.IsDisplay = false;
            obj.IsDeletedOn = DateTime.Now;
            s.Worklist.Update(obj);
            ResponseBody RB = new ResponseBody();

            RB.success = true;
            RB.msg = "Worklist Deleted Successfully";
            RB.data = "";
            return Ok(RB);
        }




    }
}
