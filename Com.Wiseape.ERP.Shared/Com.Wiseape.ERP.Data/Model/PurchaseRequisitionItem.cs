namespace Com.Wiseape.ERP.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PURCHASING.PurchaseRequisitionItem")]
    public partial class PurchaseRequisitionItem
    {
        [Key]
        public long IdPurchaseRequestItemId { get; set; }

        public int? ItemId { get; set; }

        [StringLength(250)]
        public string ItemDescription { get; set; }

        public int? Quantity { get; set; }

        public double? Price { get; set; }

        public double? ItemTotalPrice { get; set; }

        public long? PurchaseRequestId { get; set; }
    }
}
