namespace Com.Wiseape.ERP.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNTING.AccountType")]
    public partial class AccountType
    {
        [Key]
        [StringLength(50)]
        public string IdAccountType { get; set; }

        [StringLength(50)]
        public string IncreaseSign { get; set; }

        [StringLength(50)]
        public string DecreaseSign { get; set; }
    }
}
