namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HolidayMaster")]
    public partial class HolidayMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal HolidayId { get; set; }

        public string HolidayName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LeaveParameterId { get; set; }

        [StringLength(50)]
        public string LeaveParameterName { get; set; }

        public DateTime? HolidayDate { get; set; }

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
