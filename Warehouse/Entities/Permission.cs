using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class Permission
    {
        public int PermissionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Group1 { get; set; }
        public string Group2 { get; set; }
        public string Group3 { get; set; }
    }
}
