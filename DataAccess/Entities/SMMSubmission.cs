namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SMMSubmission")]
    public partial class SMMSubmission
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal SSMSubmissionId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CompanyId { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CustomerId { get; set; }

        [StringLength(50)]
        public string Customername { get; set; }

        [StringLength(50)]
        public string DomainName { get; set; }

        [StringLength(50)]
        public string PurchaseRate { get; set; }

        [StringLength(50)]
        public string SalesRate { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public DateTime? PurchaseExpiryDate { get; set; }

        public DateTime? PurchaseReminderDate { get; set; }

        public DateTime? SaleExpiryDate { get; set; }

        public DateTime? SaleReminderDate { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public string Remark { get; set; }

        public bool? IsSuspend { get; set; }

        public string SuspendRemark { get; set; }

        public bool? IsReactivate { get; set; }

        public string ReactivateRemark { get; set; }

        public bool? IsDelete { get; set; }

        public string DeleteRemark { get; set; }

        public bool? IsRecordActive { get; set; }
    }
}
