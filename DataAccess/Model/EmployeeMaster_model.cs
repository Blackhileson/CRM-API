using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class EmployeeMaster_model
    {

        public decimal EmployeeID { get; set; }
        
        public decimal? HonorificID { get; set; }
        
        public string HonorificName { get; set; }
        
        public string EmployeeName { get; set; }
        
        public decimal? CompanyID { get; set; }
        
        public string CompanyName { get; set; }
        
        public decimal? DepartmentID { get; set; }
        
        public string DepartmentName { get; set; }
        
        public decimal? ShiftID { get; set; }
        
        public string ShiftName { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }
        
        public string AltEmail { get; set; }
        
        public decimal? MobileNo { get; set; }
        
        public decimal? AltMobileNo { get; set; }
        
        public DateTime? DateOfBirth { get; set; }
        
        public string Address { get; set; }
        
        public string AltAddress { get; set; }

        public DateTime? JoiningDate { get; set; }

        public DateTime? LeaveDate { get; set; }
        
        public string Aadharcard { get; set; }
        
        public string Pincode { get; set; }
        
        public string Skill { get; set; }

        public string AboutDescription { get; set; }
        
        public string Technology { get; set; }
        
        public string Language { get; set; }

        public string ProfileImage { get; set; }
        
        public string Github { get; set; }
        
        public string Website { get; set; }
        
        public string Linkedin { get; set; }
        
        public string PanCard { get; set; }
        
        public decimal? CountryID { get; set; }
        
        public decimal? StateID { get; set; }
        
        public decimal? CityID { get; set; }
        
        public decimal? GenderID { get; set; }
        
        public decimal? DesignationID { get; set; }
        
        public decimal? BloodGrpID { get; set; }

        public bool? IsAdmin { get; set; }

        public bool? IsDisplay { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? IsAddedOn { get; set; }
        
        public decimal? IsAddedBy { get; set; }

        public DateTime? IsUpdatedOn { get; set; }
        
        public decimal? IsUpdatedBy { get; set; }

        public DateTime? IsDeletedOn { get; set; }
        
        public decimal? IsDeletedBy { get; set; }
        
        public string Username { get; set; }
        
        public string CountryName { get; set; }
        
        public string StateName { get; set; }
        
        public string CityName { get; set; }
        
        public string GendarName { get; set; }
        
        public string DesignationName { get; set; }
        
        public string BloodGroupName { get; set; }


    }
}
