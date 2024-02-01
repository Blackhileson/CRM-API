namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LeadMaster")]
    public partial class LeadMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal LeadID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CampaignContactName { get; set; }

        [StringLength(50)]
        public string LeadUniqueNo { get; set; }

        [StringLength(50)]
        public string LeadGeneratedBy { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LeadInitiatedBy { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CampaignID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SalesFunnelName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ContactGroupID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LeadInitiatedDate { get; set; }

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
