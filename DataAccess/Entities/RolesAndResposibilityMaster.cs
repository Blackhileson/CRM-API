namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RolesAndResposibilityMaster")]
    public partial class RolesAndResposibilityMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal RoleId { get; set; }

        [StringLength(80)]
        public string Designation { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Menu { get; set; }

        [StringLength(50)]
        public string MenuName { get; set; }

        public bool? ReadAccess { get; set; }

        public bool? WriteAccess { get; set; }

        public bool? EditAccess { get; set; }

        public bool? DeleteAccess { get; set; }

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
