namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DayBook")]
    public partial class DayBook
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal DayBookID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EmployeeID { get; set; }

        public DateTime Date { get; set; }

        public bool IsDisplay { get; set; }

        public bool IsActive { get; set; }

        public DateTime IsAddedOn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IsAddedBy { get; set; }

        public DateTime IsUpdatedOn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IsUpdatedBy { get; set; }

        public DateTime IsDeletedOn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IsDeletedBy { get; set; }
    }
}
