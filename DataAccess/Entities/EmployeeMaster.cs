namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeMaster")]
    public partial class EmployeeMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal EmployeeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? HonorificID { get; set; }

        [StringLength(50)]
        public string HonorificName { get; set; }

        [StringLength(50)]
        public string EmployeeName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CompanyID { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DepartmentID { get; set; }

        [StringLength(50)]
        public string DepartmentName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ShiftID { get; set; }

        [StringLength(50)]
        public string ShiftName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string AltEmail { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MobileNo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AltMobileNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string AltAddress { get; set; }

        public DateTime? JoiningDate { get; set; }

        public DateTime? LeaveDate { get; set; }

        [StringLength(50)]
        public string Aadharcard { get; set; }

        [StringLength(50)]
        public string Pincode { get; set; }

        [StringLength(200)]
        public string Skill { get; set; }

        public string AboutDescription { get; set; }

        [StringLength(200)]
        public string Technology { get; set; }

        [StringLength(200)]
        public string Language { get; set; }

        public string ProfileImage { get; set; }

        [StringLength(200)]
        public string Github { get; set; }

        [StringLength(200)]
        public string Website { get; set; }

        [StringLength(200)]
        public string Linkedin { get; set; }

        [StringLength(50)]
        public string PanCard { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CountryID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StateID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CityID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GenderID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DesignationID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BloodGrpID { get; set; }

        public bool? IsAdmin { get; set; }

        public bool? IsDisplay { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? IsAddedOn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IsAddedBy { get; set; }

        public DateTime? IsUpdatedOn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IsUpdatedBy { get; set; }

        public DateTime? IsDeletedOn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IsDeletedBy { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string CountryName { get; set; }

        [StringLength(50)]
        public string StateName { get; set; }

        [StringLength(50)]
        public string CityName { get; set; }

        [StringLength(50)]
        public string GendarName { get; set; }

        [StringLength(50)]
        public string DesignationName { get; set; }

        [StringLength(50)]
        public string BloodGroupName { get; set; }
    }
}
