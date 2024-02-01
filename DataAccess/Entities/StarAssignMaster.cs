namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StarAssignMaster")]
    public partial class StarAssignMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal StarAssignId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GetEmployeeId { get; set; }

        [StringLength(50)]
        public string GetEmployeeName { get; set; }

        public DateTime? AssignDate { get; set; }

        [StringLength(50)]
        public string Month { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StarId { get; set; }

        [StringLength(50)]
        public string StarName { get; set; }

        [StringLength(80)]
        public string StarImgURL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GivenByEmployeeId { get; set; }

        [StringLength(50)]
        public string GivenByEmployeeName { get; set; }

        public string Note { get; set; }

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
