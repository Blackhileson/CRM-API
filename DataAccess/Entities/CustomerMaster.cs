namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerMaster")]
    public partial class CustomerMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal CustomerID { get; set; }

        [StringLength(50)]
        public string ContactPersonName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DesignationID { get; set; }

        [StringLength(50)]
        public string DesignationName { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string EmailID { get; set; }

        [StringLength(50)]
        public string CompanyAddress { get; set; }

        [StringLength(50)]
        public string CompanyEmail { get; set; }

        [StringLength(50)]
        public string CompanyMobileNo { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string CompanyType { get; set; }

        [StringLength(50)]
        public string MobileNo { get; set; }

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
