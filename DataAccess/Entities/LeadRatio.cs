namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LeadRatio")]
    public partial class LeadRatio
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal LeadRatioID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LeadNameID { get; set; }

        [StringLength(50)]
        public string LeadName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LeadGroupNameID { get; set; }

        [StringLength(50)]
        public string LeadGroupName { get; set; }

        [StringLength(50)]
        public string LeadTitle { get; set; }

        [StringLength(50)]
        public string Progress { get; set; }

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
