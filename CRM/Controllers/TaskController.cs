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
    [RoutePrefix("api/Task")]
    public class TaskController : ApiController
    {


        string BaseURL = System.Configuration.ConfigurationManager.AppSettings["AdminBaseURI"];
        Service s;

        public TaskController()
        {
            s = new Service();
        }



        [Route("AddTaskDetails")]
        [HttpPost]
        public IHttpActionResult AddTaskDetails([FromBody] List<TaskModel> taskModels)
        {

            ResponseBody RB = new ResponseBody();

            foreach (TaskModel e in taskModels)
            {

                int employeeID = Convert.ToInt32(e.employeeId);
                EmployeeMaster emp = s.ManageEmployeeMaster.Get(employeeID);


                if (e.TaskListID == 0)
                {

                    TaskListMaster o = new TaskListMaster();

                    o.ProjectName = e.ProjectName;
                    o.ProjectID = e.ProjectID;
                    o.ProjectPhaseName = e.ProjectPhaseName;
                    o.ProjectPhaseID = e.ProjectPhaseID;
                    o.WorkListName = e.WorkListName;
                    o.WorkListID = e.WorkListID;
                    o.WorkingDescriprion = e.WorkingDescriprion;
                    o.StartDate = e.StartDate;
                    o.ExceptedDate = e.ExceptedDate;
                    o.WorkingHours = e.WorkingHours;
                    o.Status = e.Status;
                    o.Employee = e.Employee;
                    o.IsAddedBy = Convert.ToString(emp.EmployeeID);
                    o.IsAddedOn = DateTime.Now;
                    o.IsActive = true;
                    o.IsDisplay = true;

                    TaskListMaster pm = s.TaskList.Add(o);

                }

                else
                {
                    return NotFound();
                }
            }

            RB.success = true;
            RB.msg = "Task Details Added!";
            RB.data = taskModels.Select(e => e.TaskListID).ToList();
            return Ok(RB);

        }


        [Route("UpdateTaskDetails")]
        [HttpPost]
        public IHttpActionResult UpdateTaskDetails(List<TaskModel> taskModels)
        {
            ResponseBody RB = new ResponseBody();

            foreach (TaskModel e in taskModels)
            {
                int employeeID = Convert.ToInt32(e.employeeId);
                EmployeeMaster emp = s.ManageEmployeeMaster.Get(employeeID);

                TaskListMaster e1 = s.TaskList.GetTaskById((int)e.TaskListID);

                if (e1 != null)
                {
                    e1.ProjectName = e.ProjectName;
                    e1.ProjectID = e.ProjectID;
                    e1.ProjectPhaseName = e.ProjectPhaseName;
                    e1.ProjectPhaseID = e.ProjectPhaseID;
                    e1.WorkListName = e.WorkListName;
                    e1.WorkListID = e.WorkListID;
                    e1.WorkingDescriprion = e.WorkingDescriprion;
                    e1.StartDate = e.StartDate;
                    e1.ExceptedDate = e.ExceptedDate;
                    e1.WorkingHours = e.WorkingHours;
                    e1.Status = e.Status;
                    e1.Employee = e.Employee;
                    e1.IsAddedBy = Convert.ToString(emp.EmployeeID);
                    e1.IsAddedOn = DateTime.Now;
                    e1.IsActive = true;
                    e1.IsDisplay = true;

                    s.TaskList.Update(e1);
                }
                else
                {
                    RB.success = false;
                    RB.msg = "Task not found for TaskDayID: " + e.TaskListID;
                    RB.data = null;
                    return Ok(RB);
                }
            }

            RB.success = true;
            RB.msg = "Details Updated Successfully";
            RB.data = taskModels.Select(e => e.TaskListID).ToList();
            return Ok(RB);
        }



        [Route("DeleteTaskbyId/{Id}")]
        [HttpPost]
        public IHttpActionResult DeleteTaskbyId([FromUri]  int Id)
        {

            TaskListMaster obj = s.TaskList.Get(Id);
            obj.IsActive = false;
            obj.IsDisplay = false;
            obj.IsDeletedOn = DateTime.Now;
            s.TaskList.Update(obj);
            ResponseBody RB = new ResponseBody();

            RB.success = true;
            RB.msg = "Task Deleted Successfully";
            RB.data = "";
            return Ok(RB);
        }


        [Route("GetTaskListView/{LoggedInEmployeeId}")]
        [HttpGet]
        public IHttpActionResult GetTaskListView([FromUri] int LoggedInEmployeeId)
        {
            EmployeeMaster emp = s.ManageEmployeeMaster.Get().Where(c => c.EmployeeID == LoggedInEmployeeId).FirstOrDefault();
            List<TaskListMaster> CL = s.TaskList.Get().Where(c => c.Employee == emp.EmployeeID && c.Status != '4' && c.IsActive == true && c.IsDisplay == true).ToList();

            ResponseBody RB = new ResponseBody();
            if (CL != null)
            {
                RB.success = true;
                RB.msg = "Data Rendering Successfully";
                RB.data = CL;
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

        [Route("AddTaskRequest")]
        [HttpPost]
        public IHttpActionResult AddTaskRequest([FromBody] TaskRequestModel e)
        {

            ResponseBody RB = new ResponseBody();
            int employeeID = Convert.ToInt32(e.employeeId);
            EmployeeMaster emp = s.ManageEmployeeMaster.Get(employeeID);


            if (e.DailyTaskID == 0)
            {

                DailytaskMaster o = new DailytaskMaster();

                o.TaskListID = e.TaskListID;
                o.ProjectName = e.ProjectName;
                o.ProjectID = e.ProjectID;
                o.ProjectPhaseName = e.ProjectPhaseName;
                o.ProjectPhaseID = e.ProjectPhaseID;
                o.WorkListName = e.WorkListName;
                o.WorkListID = e.WorkListID;
                o.TodayWorkingHours = e.TodayWorkingHours;
                o.Priority = e.Priority;
                o.EmployeeId = e.EmployeeId;
                o.IsApprove = e.IsApprove;
                o.IsAddedBy = emp.EmployeeID;
                o.IsAddedOn = DateTime.Now;
                o.IsActive = true;
                o.IsDisplay = true;

                DailytaskMaster pm = s.Dailytask.Add(o);

                RB.success = true;
                RB.msg = "Dailytask Added!";
                RB.data = pm.DailyTaskID;
                return Ok(RB);
            }

            else
            {
                return NotFound();
            }


        }
        


    }
}
