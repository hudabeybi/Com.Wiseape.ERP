namespace Com.Wiseape.ERP.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSTEM.GlobalApplicationSettingTemplate")]
    public partial class GlobalApplicationSettingTemplate
    {
        [Key]
        public int IdGlobalApplicationSettingTemplate { get; set; }

        [StringLength(250)]
        public string ApplicationSettingName { get; set; }

        [Column(TypeName = "text")]
        public string ApplicationSettingValue { get; set; }

        public int? IsActive { get; set; }
    }
}
