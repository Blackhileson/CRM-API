namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SEOSubmissionMaster")]
    public partial class SEOSubmissionMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal SEOSubmissionID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CompanyId { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string Customer { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string DomainName { get; set; }

        [StringLength(50)]
        public string SupplierId { get; set; }

        [StringLength(50)]
        public string SupplierName { get; set; }

        [StringLength(50)]
        public string PurchaseRate { get; set; }

        [StringLength(50)]
        public string SaleRate { get; set; }

        public string Remark { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public DateTime? PurchaseExpiryDate { get; set; }

        public DateTime? PurchaseReminderDate { get; set; }

        public DateTime? SaleExpiryDate { get; set; }

        public DateTime? SaleReminderDate { get; set; }

        public string ControllerURL { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string CustomerId { get; set; }

        [StringLength(50)]
        public string SupportPIN { get; set; }

        public bool? IsSuspend { get; set; }

        public string SuspendRemark { get; set; }

        public bool? isReactivate { get; set; }

        public string ReactivateRemark { get; set; }

        public bool? IsDelete { get; set; }

        public string DeleteRemark { get; set; }

        public bool? IsRecordActive { get; set; }
    }
}
