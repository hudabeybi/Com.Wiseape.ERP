namespace Com.Wiseape.ERP.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PURCHASING.PurchaseOrder")]
    public partial class PurchaseOrder
    {
        [Key]
        public long IdPO { get; set; }

        [StringLength(250)]
        public string PONumber { get; set; }

        public DateTime? PODate { get; set; }

        public DateTime? POCreatedDate { get; set; }

        public int? VendorId { get; set; }

        [Column(TypeName = "text")]
        public string VendorAddress { get; set; }

        [StringLength(250)]
        public string VendorEmail { get; set; }

        [StringLength(250)]
        public string VendorPhone { get; set; }

        [Column(TypeName = "text")]
        public string ShipmentToAddress { get; set; }

        [StringLength(250)]
        public string ShipmentToPhone { get; set; }

        public int? ShippingMethodId { get; set; }

        public int? ShippingTermId { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public int? PaymentTermId { get; set; }

        public int? AuthorizedById { get; set; }

        public int? RequesterId { get; set; }

        public int? RequesterDepartmentId { get; set; }

        [Column(TypeName = "text")]
        public string Note { get; set; }

        public int? IsActive { get; set; }
    }
}
