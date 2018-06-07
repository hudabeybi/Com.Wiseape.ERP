namespace Com.Wiseape.ERP.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HUMANRESOURCE.Organization")]
    public partial class Organization
    {
        [Key]
        public int IdOrganization { get; set; }

        [StringLength(250)]
        public string OrganizationNo { get; set; }

        [StringLength(250)]
        public string OrganizationName { get; set; }

        [Column(TypeName = "text")]
        public string OrganizationInfo { get; set; }

        [Column(TypeName = "text")]
        public string OrganizationPicture { get; set; }

        public int? ParentOrganizationId { get; set; }

        public int? IsActive { get; set; }
    }
}
