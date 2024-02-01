namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DailytaskMaster")]
    public partial class DailytaskMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal DailyTaskID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TaskListID { get; set; }

        public string ProjectName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ProjectID { get; set; }

        [StringLength(500)]
        public string ProjectPhaseName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ProjectPhaseID { get; set; }

        [StringLength(500)]
        public string WorkListName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WorkListID { get; set; }

        public TimeSpan? TodayWorkingHours { get; set; }

        [StringLength(50)]
        public string Priority { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EmployeeId { get; set; }

        public bool? IsApprove { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public string RejectRemark { get; set; }

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
