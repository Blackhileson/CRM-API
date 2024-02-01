namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MeetingMOMMaster")]
    public partial class MeetingMOMMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal MeetingMOMID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ProjectID { get; set; }

        [StringLength(500)]
        public string ProjectName { get; set; }

        public string JoinEmployee { get; set; }

        public string JoinedBy { get; set; }

        public string ApprovedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public TimeSpan? FromTime { get; set; }

        public TimeSpan? ToTime { get; set; }

        public string Location { get; set; }

        public string Attachment { get; set; }

        public string Discussion { get; set; }

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
