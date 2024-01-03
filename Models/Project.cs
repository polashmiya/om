using System;
using System.Collections.Generic;

namespace OM.Models
{
    public partial class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; } = null!;
        public int? TeamMemberId { get; set; }
    }
}
