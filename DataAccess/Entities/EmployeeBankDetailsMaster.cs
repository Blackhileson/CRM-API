namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeBankDetailsMaster")]
    public partial class EmployeeBankDetailsMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal EmployeeBankDetailID { get; set; }

        [StringLength(50)]
        public string PrintedNameInBankAccount { get; set; }

        [StringLength(50)]
        public string BankAccountNo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BankID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BankACTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BankACType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BankName { get; set; }

        [StringLength(50)]
        public string MICRCode { get; set; }

        [StringLength(50)]
        public string IFSCCode { get; set; }

        [StringLength(50)]
        public string AadharCardNO { get; set; }

        [StringLength(50)]
        public string FileUploadAdharCard { get; set; }

        [StringLength(50)]
        public string PanCardNO { get; set; }

        [StringLength(50)]
        public string FileUploadPancardNo { get; set; }

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
