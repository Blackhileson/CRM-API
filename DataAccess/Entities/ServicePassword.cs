namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServicePassword")]
    public partial class ServicePassword
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ServicePasswordID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CompanyId { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Customer { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        public string URL { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RegistrationDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PurchaseExpiryDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PurchaseReminderDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SaleExpiryDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SaleReminderDate { get; set; }

        public string SecurityQuestion { get; set; }

        public string SecurityAns { get; set; }

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
