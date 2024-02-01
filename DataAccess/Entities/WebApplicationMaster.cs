namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebApplicationMaster")]
    public partial class WebApplicationMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal WebsiteApplicationID { get; set; }

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

        [StringLength(50)]
        public string DBServerIP { get; set; }

        [StringLength(50)]
        public string DatabaseName { get; set; }

        [StringLength(50)]
        public string DatabaseUsername { get; set; }

        [StringLength(50)]
        public string DatabasePassword { get; set; }

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
        public string PurchaseRate { get; set; }

        [StringLength(50)]
        public string SaleRate { get; set; }

        [StringLength(50)]
        public string DatabaseServer { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BusinessCategoryId { get; set; }

        [StringLength(50)]
        public string BusinessCategoryName { get; set; }

        [StringLength(50)]
        public string AppVersion { get; set; }

        public bool? IsSuspend { get; set; }

        public string SuspendRemark { get; set; }

        public bool? IsReactivate { get; set; }

        public string ReactivateRemark { get; set; }

        public bool? IsDelete { get; set; }

        public string DeleteRemark { get; set; }

        [StringLength(50)]
        public string Network { get; set; }

        [StringLength(50)]
        public string AdminControllerURL { get; set; }

        [StringLength(50)]
        public string AdminControllerUserName { get; set; }

        [StringLength(50)]
        public string AdminControllerPassword { get; set; }

        [StringLength(50)]
        public string AdminControllerUserAs { get; set; }

        [StringLength(50)]
        public string ControlPanel1URL { get; set; }

        [StringLength(50)]
        public string ControlPanel1UserName { get; set; }

        [StringLength(50)]
        public string ControlPanel1Password { get; set; }

        [StringLength(50)]
        public string ControlPanel1UserAs { get; set; }

        [StringLength(50)]
        public string ControlPanel2URL { get; set; }

        [StringLength(50)]
        public string ControlPanel2UserName { get; set; }

        [StringLength(50)]
        public string ControlPanel2Password { get; set; }

        [StringLength(50)]
        public string ControlPanel2UserAs { get; set; }

        [StringLength(50)]
        public string ControlPanel3URL { get; set; }

        [StringLength(50)]
        public string ControlPanel3UserName { get; set; }

        [StringLength(50)]
        public string ControlPanel3Password { get; set; }

        [StringLength(50)]
        public string ControlPanel3UserAs { get; set; }

        public bool? IsRecordActive { get; set; }
    }
}
