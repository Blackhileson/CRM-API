namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyMaster")]
    public partial class CompanyMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal CompanyId { get; set; }

        public string CompanyName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IndustrialSectorId { get; set; }

        [StringLength(50)]
        public string IndustrialSectorName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CompanyAge { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EstablishmentId { get; set; }

        [StringLength(50)]
        public string Establishment { get; set; }

        public string CompanyStatus { get; set; }

        public string Address { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CityId { get; set; }

        [StringLength(50)]
        public string CityName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal StateId { get; set; }

        [StringLength(50)]
        public string StateName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CountryId { get; set; }

        [StringLength(50)]
        public string CountryName { get; set; }

        public string Email { get; set; }

        public string MobileNumber { get; set; }

        public string LandlineNumber { get; set; }

        public string ContactPersonName { get; set; }

        public string GSTNumber { get; set; }

        public string Turnover { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NumberofEmployees { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WorkingDaysinweek { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WorkingHoursinday { get; set; }

        public string Website { get; set; }

        public string WebsiteStatus { get; set; }

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
    }
}
