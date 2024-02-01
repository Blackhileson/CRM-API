namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaskListMaster")]
    public partial class TaskListMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal TaskListID { get; set; }

        [StringLength(500)]
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

        public string WorkingDescriprion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExceptedDate { get; set; }

        public TimeSpan? WorkingHours { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Status { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Employee { get; set; }

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
