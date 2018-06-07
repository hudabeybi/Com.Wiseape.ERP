namespace Com.Wiseape.ERP.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DESKTOP.Theme")]
    public partial class Theme
    {
        [Key]
        public int IdTheme { get; set; }

        [StringLength(250)]
        public string ThemeName { get; set; }

        [Column(TypeName = "text")]
        public string ThemeInfo { get; set; }

        [Column(TypeName = "text")]
        public string LoadingAnimation { get; set; }

        [Column(TypeName = "text")]
        public string LoadingAnimationAudio { get; set; }

        [StringLength(250)]
        public string DefaultWallpaper { get; set; }

        [StringLength(250)]
        public string TaskbarColor { get; set; }

        [StringLength(250)]
        public string TaskbarMenuColor { get; set; }
    }
}
