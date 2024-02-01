namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaskTransferMaster")]
    public partial class TaskTransferMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal TaskTransferID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TaskListID { get; set; }

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

        [StringLength(500)]
        public string Remark { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EmployeeFrom { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EmployeeTo { get; set; }

        [StringLength(500)]
        public string EmployeeFromName { get; set; }

        [StringLength(500)]
        public string EmployeeToName { get; set; }

        public bool? IsApproval { get; set; }

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
