namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyDocumentTypeMaster")]
    public partial class CompanyDocumentTypeMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal CompanyDocumentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DocumentID { get; set; }

        [StringLength(50)]
        public string DocumentName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CompanyID { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        public string UploadFile { get; set; }

        public DateTime? CreatedDate { get; set; }

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
