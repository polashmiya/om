using System;
using System.Collections.Generic;

namespace OM.Models
{
    public partial class Supplier
    {
        public long SupplierId { get; set; }
        public string SupplierName { get; set; } = null!;
        public string SupplierMobileNo { get; set; } = null!;
        public string? SupplierAddress { get; set; }
        public bool? IsActive { get; set; }
    }
}
