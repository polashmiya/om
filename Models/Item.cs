using System;
using System.Collections.Generic;

namespace OM.Models
{
    public partial class Item
    {
        public long ItemId { get; set; }
        public string ItemName { get; set; } = null!;
        public long UomId { get; set; }
        public string UomName { get; set; } = null!;
        public long? PurchasePrice { get; set; }
        public long? SellingPrice { get; set; }
        public bool IsActive { get; set; }
    }
}
