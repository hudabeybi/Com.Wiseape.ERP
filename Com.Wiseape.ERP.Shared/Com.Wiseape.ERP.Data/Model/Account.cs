namespace Com.Wiseape.ERP.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNTING.Account")]
    public partial class Account
    {
        [Key]
        public int IdAccount { get; set; }

        [StringLength(50)]
        public string AccountNo { get; set; }

        [StringLength(250)]
        public string AccountNama { get; set; }

        public int? ParentAccountId { get; set; }

        [StringLength(50)]
        public string AccountType { get; set; }

        public int? IsActive { get; set; }
    }
}
