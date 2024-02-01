namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebHosting")]
    public partial class WebHosting
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal WebHostingID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CompanyId { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Customer { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string DomainName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SupplierId { get; set; }

        [StringLength(50)]
        public string SupplierName { get; set; }

        [StringLength(50)]
        public string PurchaseRate { get; set; }

        [StringLength(50)]
        public string SaleRate { get; set; }

        public string Remark { get; set; }

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

        public bool? IsReactivate { get; set; }

        public string ReactivateRemark { get; set; }

        public bool? IsDelete { get; set; }

        public string DeleteRemark { get; set; }

        public string MXRecord1 { get; set; }

        public string MXRecord2 { get; set; }

        public string MXRecord3 { get; set; }

        public string MXRecord4 { get; set; }

        public string NameServer1 { get; set; }

        public string NameServer2 { get; set; }

        public string NameServer3 { get; set; }

        public string NameServer4 { get; set; }

        public string CNAMERecord1 { get; set; }

        public string CNAMERecord2 { get; set; }

        public string CNAMERecord3 { get; set; }

        public string TXTRecord1 { get; set; }

        public string TXTRecord2 { get; set; }

        public string TXTRecord3 { get; set; }

        public string TXTRecord4 { get; set; }

        public string ARecord1 { get; set; }

        public string ARecord2 { get; set; }

        public string ARecord3 { get; set; }

        public bool? IsRecordActive { get; set; }
    }
}
