namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DailyWorkBook")]
    public partial class DailyWorkBook
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal DailyWorkBookID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public TimeSpan? FromTime { get; set; }

        public TimeSpan? ToTime { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Project { get; set; }

        [StringLength(500)]
        public string ProjectName { get; set; }

        [StringLength(500)]
        public string ProjectPhaseName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ProjectPhaseID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TaskListID { get; set; }

        [StringLength(50)]
        public string TaskInfo { get; set; }

        [StringLength(50)]
        public string TaskBackUpPath { get; set; }

        [StringLength(50)]
        public string WorkReport { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Status { get; set; }

        [StringLength(50)]
        public string StatusName { get; set; }

        public bool? IsSave { get; set; }

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
