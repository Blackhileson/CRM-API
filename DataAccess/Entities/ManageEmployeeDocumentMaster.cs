namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ManageEmployeeDocumentMaster")]
    public partial class ManageEmployeeDocumentMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal EmployeeDocumentID { get; set; }

        [StringLength(50)]
        public string EmployeeName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EmployeeID { get; set; }

        [StringLength(50)]
        public string DocumentTypeID { get; set; }

        [StringLength(50)]
        public string DocumentTypeName { get; set; }

        public string FileUpload { get; set; }

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
