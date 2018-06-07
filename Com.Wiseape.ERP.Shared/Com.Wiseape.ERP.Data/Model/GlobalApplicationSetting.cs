namespace Com.Wiseape.ERP.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSTEM.GlobalApplicationSetting")]
    public partial class GlobalApplicationSetting
    {
        [Key]
        public int IdGlobalApplicationSetting { get; set; }

        [StringLength(250)]
        public string SettingName { get; set; }

        [Column(TypeName = "text")]
        public string SettingValue { get; set; }

        [StringLength(50)]
        public string UserID { get; set; }
    }
}
