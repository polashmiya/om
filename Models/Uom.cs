using System;
using System.Collections.Generic;

namespace OM.Models
{
    public partial class Uom
    {
        public long UomId { get; set; }
        public string UomName { get; set; } = null!;
        public bool? IsActive { get; set; }
    }
}
