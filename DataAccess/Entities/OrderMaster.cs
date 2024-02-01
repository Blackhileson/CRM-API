namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderMaster")]
    public partial class OrderMaster
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal OrderMasterID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LeadId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ServiceGroup { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OrderID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ProjectManager { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OrderOpeningDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OrderClosingDate { get; set; }

        [StringLength(50)]
        public string OrderAttachment { get; set; }

        [StringLength(50)]
        public string Remarks { get; set; }

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
