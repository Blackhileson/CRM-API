namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProjectMeetingMaster")]
    public partial class ProjectMeetingMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ProjectMeetingID { get; set; }

        public string ProjectMeetingName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CompanyID { get; set; }

        public string CompanyName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ProjectID { get; set; }

        [StringLength(500)]
        public string ProjectName { get; set; }

        public string JoinEmployee { get; set; }

        public string JoinedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public TimeSpan? FromTime { get; set; }

        public TimeSpan? ToTime { get; set; }

        public string AgendaItems { get; set; }

        public string Discussion { get; set; }

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
