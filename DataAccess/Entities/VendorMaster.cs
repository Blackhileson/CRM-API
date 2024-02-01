namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VendorMaster")]
    public partial class VendorMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal VendorID { get; set; }

        [StringLength(50)]
        public string VendorName { get; set; }

        [StringLength(50)]
        public string EmailID { get; set; }

        [StringLength(50)]
        public string MobileNo { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Country { get; set; }

        [StringLength(50)]
        public string CountryName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? State { get; set; }

        [StringLength(50)]
        public string StateName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? City { get; set; }

        [StringLength(50)]
        public string CityName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Gender { get; set; }

        [StringLength(50)]
        public string GenderName { get; set; }

        [StringLength(50)]
        public string GSTNo { get; set; }

        [StringLength(50)]
        public string WebsiteURL { get; set; }

        [StringLength(50)]
        public string ContactPersonName { get; set; }

        [StringLength(50)]
        public string ContactPersonEmail { get; set; }

        [StringLength(50)]
        public string ContactPersonMobileNo { get; set; }

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
