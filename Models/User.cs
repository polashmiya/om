using System;
using System.Collections.Generic;

namespace OM.Models
{
    public partial class User
    {
        public long UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string? MobileNo { get; set; }
        public string? EmailAddress { get; set; }
        public long Password { get; set; }
        public bool IsActive { get; set; }
        public string FullName { get; set; } = null!;
    }
}
