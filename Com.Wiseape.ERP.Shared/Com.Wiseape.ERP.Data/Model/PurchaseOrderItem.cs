namespace Com.Wiseape.ERP.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PURCHASING.PurchaseOrderItem")]
    public partial class PurchaseOrderItem
    {
        [Key]
        public long IdPurchaseOrderItem { get; set; }

        public int? ItemId { get; set; }

        [StringLength(250)]
        public string ItemDescription { get; set; }

        public double? Quantity { get; set; }

        public double? ItemPrice { get; set; }

        public int? ItemJobId { get; set; }

        public double? ItemTotalPrice { get; set; }

        public long? PurchaseOrderId { get; set; }
    }
}
