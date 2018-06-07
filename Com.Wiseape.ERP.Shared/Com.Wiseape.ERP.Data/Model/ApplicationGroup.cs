namespace Com.Wiseape.ERP.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSTEM.ApplicationGroup")]
    public partial class ApplicationGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ApplicationGroup()
        {
            ApplicationItems = new HashSet<ApplicationItem>();
        }

        [Key]
        public int IdApplicationGroup { get; set; }

        [StringLength(250)]
        public string ApplicationGroupName { get; set; }

        [Column(TypeName = "text")]
        public string ApplicationGroupDesc { get; set; }

        [Column(TypeName = "text")]
        public string ApplicationGroupIcon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationItem> ApplicationItems { get; set; }
    }
}
