using System;
using System.Collections.Generic;

namespace OM.Models
{
    public partial class Customer
    {
        public long CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
        public string CustomerMobileNo { get; set; } = null!;
        public string? CustomerAddress { get; set; }
        public bool? IsActive { get; set; }
    }
}
