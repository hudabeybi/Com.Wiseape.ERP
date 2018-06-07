namespace Com.Wiseape.ERP.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HUMANRESOURCE.Employee")]
    public partial class Employee
    {
        [Key]
        public int IdEmployee { get; set; }

        [StringLength(250)]
        public string EmployeeNo { get; set; }

        [StringLength(250)]
        public string IdentityNumber { get; set; }

        [StringLength(250)]
        public string FirstName { get; set; }

        [StringLength(250)]
        public string MiddleName { get; set; }

        [StringLength(250)]
        public string LastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }

        public int? BirthPlaceId { get; set; }

        public int GenderId { get; set; }

        [Column(TypeName = "text")]
        public string LivingAddress { get; set; }

        [Column(TypeName = "text")]
        public string HomeAddress { get; set; }

        [StringLength(50)]
        public string HomePhone { get; set; }

        [StringLength(50)]
        public string MobilePhone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? OrganizationId { get; set; }

        public int? IsActive { get; set; }
    }
}
