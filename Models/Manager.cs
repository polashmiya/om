using System;
using System.Collections.Generic;

namespace OM.Models
{
    public partial class Manager
    {
        public int ManagerId { get; set; }
        public string ManagerName { get; set; } = null!;
        public int? DepartmentId { get; set; }
    }
}
