namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BankInfromationMaster")]
    public partial class BankInfromationMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal BankInfromationID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EmployeeID { get; set; }

        [StringLength(50)]
        public string EmployeeName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BankID { get; set; }

        [StringLength(50)]
        public string BankName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BankACTypeID { get; set; }

        [StringLength(50)]
        public string BankACTypeName { get; set; }

        [StringLength(50)]
        public string NameOnPassBook { get; set; }

        [StringLength(50)]
        public string BankACNumber { get; set; }

        [StringLength(50)]
        public string IFSCcode { get; set; }

        public DateTime? OpeningDate { get; set; }

        public string Remarks { get; set; }

        public bool? IsDisplay { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? IsAddedOn { get; set; }

        [StringLength(50)]
        public string IsAddedBy { get; set; }

        public DateTime? IsUpdatedOn { get; set; }

        [StringLength(50)]
        public string IsUpdatedBy { get; set; }

        public DateTime? IsDeletedOn { get; set; }

        [StringLength(50)]
        public string IsDeletedBy { get; set; }
    }
}
