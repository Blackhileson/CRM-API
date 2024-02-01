namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaskDay")]
    public partial class TaskDay
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal TaskDayID { get; set; }

        public string EmployeeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ProjectID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ProjectPhaseID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WorkListID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Enddate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StatusID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WorkHours { get; set; }

        public bool? IsDisplay { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? IsAddedOn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IsAddedBy { get; set; }

        public DateTime? IsUpdatedOn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IsUpdatedBy { get; set; }

        public DateTime? IsDeletedOn { get; set; }

        public DateTime? IsDeletedBy { get; set; }
    }
}
