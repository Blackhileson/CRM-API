namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientMaster")]
    public partial class ClientMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ClientID { get; set; }

        [StringLength(50)]
        public string ClientName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CompanyId { get; set; }

        [StringLength(500)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string SalesPersonName { get; set; }

        [StringLength(50)]
        public string SalesPersonEmail { get; set; }

        [StringLength(50)]
        public string SupportPersonName { get; set; }

        [StringLength(50)]
        public string SupportPersonEmail { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(50)]
        public string OfficeNumone { get; set; }

        [StringLength(50)]
        public string OfficePhone { get; set; }

        [StringLength(50)]
        public string MobileNo { get; set; }

        [StringLength(50)]
        public string MobileNum { get; set; }

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
