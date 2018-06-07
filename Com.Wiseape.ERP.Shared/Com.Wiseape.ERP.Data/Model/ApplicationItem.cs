namespace Com.Wiseape.ERP.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSTEM.ApplicationItem")]
    public partial class ApplicationItem
    {
        [Key]
        public int IdApplication { get; set; }

        [StringLength(250)]
        public string ApplicationName { get; set; }

        [StringLength(250)]
        public string ApplicationTitle { get; set; }

        [Column(TypeName = "text")]
        public string ApplicationIcon { get; set; }

        [Column(TypeName = "text")]
        public string ApplicationDesc { get; set; }

        public int? ApplicationGroupId { get; set; }

        [Column(TypeName = "text")]
        public string ApplicationPath { get; set; }

        [StringLength(250)]
        public string ApplicationFile { get; set; }

        [StringLength(250)]
        public string ApplicationClass { get; set; }

        [StringLength(250)]
        public string ApplicationStartFunction { get; set; }

        public int? IsDisplayed { get; set; }

        public virtual ApplicationGroup ApplicationGroup { get; set; }
    }
}
