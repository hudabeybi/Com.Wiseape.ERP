namespace Com.Wiseape.ERP.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PURCHASING.PurchaseRequisition")]
    public partial class PurchaseRequisition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IdPurchaseRequest { get; set; }

        [StringLength(250)]
        public string PurchaseRequestNo { get; set; }

        public DateTime? PurchaseRequestDate { get; set; }

        [Column(TypeName = "text")]
        public string Reason { get; set; }

        public DateTime? RequiredBeforeDate { get; set; }

        public int? VendorId { get; set; }

        public int? RequesterId { get; set; }

        public int? RequesterDepartmentId { get; set; }

        public int? IsActive { get; set; }
    }
}
