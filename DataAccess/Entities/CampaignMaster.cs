namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CampaignMaster")]
    public partial class CampaignMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal CampaignID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CampaignCategoryName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CampaignContactID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SalesFunnelId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CampaignDate { get; set; }

        [StringLength(50)]
        public string CampaignBy { get; set; }

        [StringLength(50)]
        public string CampaignName { get; set; }

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
