namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebDesignMaster")]
    public partial class WebDesignMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal WebsiteDesigningID { get; set; }

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

        [StringLength(50)]
        public string NoPages { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BusinessCategoryId { get; set; }

        [StringLength(50)]
        public string BusinessCategoryName { get; set; }

        public string Remark { get; set; }

        public bool? IsDisplay { get; set; }

        public bool? IsRecordActive { get; set; }
    }
}
