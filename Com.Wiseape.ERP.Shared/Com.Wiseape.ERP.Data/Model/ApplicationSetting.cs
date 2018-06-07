namespace Com.Wiseape.ERP.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSTEM.ApplicationSetting")]
    public partial class ApplicationSetting
    {
        [Key]
        public int IdApplicationSetting { get; set; }

        [StringLength(50)]
        public string SettingKey { get; set; }

        [Column(TypeName = "text")]
        public string SettingValue { get; set; }

        [StringLength(250)]
        public string AppName { get; set; }
    }
}
