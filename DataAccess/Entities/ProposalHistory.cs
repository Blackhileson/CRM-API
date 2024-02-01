namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProposalHistory")]
    public partial class ProposalHistory
    {
        [Column(TypeName = "numeric")]
        public decimal ProposalHistoryID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LeadName { get; set; }

        [StringLength(50)]
        public string AddProposal { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

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
