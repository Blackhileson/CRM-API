namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmailCredentialMaster")]
    public partial class EmailCredentialMaster
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal EmailCredentialID { get; set; }

        [StringLength(50)]
        public string EmailCredentialName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EmployeeID { get; set; }

        [StringLength(50)]
        public string EmployeeName { get; set; }

        public string Description { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string EmailAddress { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string HostServiceProvider { get; set; }

        [StringLength(50)]
        public string SMTP { get; set; }

        [StringLength(50)]
        public string Port { get; set; }

        public bool? ISSSL { get; set; }

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
