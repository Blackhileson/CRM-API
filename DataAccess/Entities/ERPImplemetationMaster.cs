namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERPImplemetationMaster")]
    public partial class ERPImplemetationMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ERPImplementationId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CompanyId { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CustomerId { get; set; }

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

        public DateTime? RegistrationDate { get; set; }

        public DateTime? PurchaseExpiryDate { get; set; }

        public DateTime? PurchaseReminderDate { get; set; }

        public DateTime? SaleExpiryDate { get; set; }

        public DateTime? SaleReminderDate { get; set; }

        [StringLength(50)]
        public string PurchaseRate { get; set; }

        [StringLength(50)]
        public string SalesRate { get; set; }

        [StringLength(50)]
        public string AppVersion { get; set; }

        [StringLength(50)]
        public string DatabaseServer { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BusinessCategoryID { get; set; }

        [StringLength(50)]
        public string BusinessCategoryName { get; set; }

        public string Remark { get; set; }

        public bool? IsSuspend { get; set; }

        public string SuspendRemark { get; set; }

        public bool? IsReactivate { get; set; }

        public string ReactivateRemark { get; set; }

        public bool? IsDelete { get; set; }

        public string DeletedRemark { get; set; }

        public bool? IsRecordActive { get; set; }

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

        [StringLength(50)]
        public string Network { get; set; }
    }
}
