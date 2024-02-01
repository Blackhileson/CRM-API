namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NoticeBoardMaster")]
    public partial class NoticeBoardMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal NoticeBoardId { get; set; }

        public string NoticeTitle { get; set; }

        public DateTime? NoticeDate { get; set; }

        public string DocumentUrl { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EmployeeName { get; set; }

        public string Description { get; set; }

        public bool? IsToAllEmployee { get; set; }

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
