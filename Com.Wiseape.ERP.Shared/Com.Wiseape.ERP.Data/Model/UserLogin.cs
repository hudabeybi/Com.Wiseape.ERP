namespace Com.Wiseape.ERP.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USERMANAGEMENT.UserLogin")]
    public partial class UserLogin
    {
        [Key]
        public int IdUser { get; set; }

        [StringLength(250)]
        public string IdentityNo { get; set; }

        [StringLength(250)]
        public string FirstName { get; set; }

        [StringLength(250)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string UserPassword { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? IsActive { get; set; }
    }
}
