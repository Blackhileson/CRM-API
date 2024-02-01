namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CampaignCategory")]
    public partial class CampaignCategory
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal CampaignCategoryID { get; set; }

        [StringLength(50)]
        public string CampaignOwner { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CampaignName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Status { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [StringLength(50)]
        public string RevenueIncampaign { get; set; }

        [StringLength(50)]
        public string BudgeteCostIncampaign { get; set; }

        [StringLength(50)]
        public string ActualCostInCampaign { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LeadsInCampaign { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ContactInCampaign { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

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
