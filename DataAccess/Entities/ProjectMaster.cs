namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProjectMaster")]
    public partial class ProjectMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ProjectID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CompanyID { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ServiceGroupID { get; set; }

        [StringLength(10)]
        public string ServiceGroupName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CustomerID { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ProjectLeaderId { get; set; }

        [StringLength(50)]
        public string ProjectLeaderName { get; set; }

        [StringLength(50)]
        public string ProjectName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpectedStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ActualStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpectedEndDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ActualEndDate { get; set; }

        public string Langauge { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TechnologyId { get; set; }

        [StringLength(50)]
        public string TechnologyName { get; set; }

        [StringLength(50)]
        public string Hardware { get; set; }

        public string Skill { get; set; }

        [StringLength(50)]
        public string ProjectStatus { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ProjectMangerID { get; set; }

        [StringLength(50)]
        public string ProjectManagerName { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public bool? IsMultiPhase { get; set; }

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
