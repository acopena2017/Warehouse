using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class MenuGroup
    {
        public int MenuGroupId { get; set; }
        public string MenuGroupName { get; set; }
        public int? MenuGroupOrder { get; set; }
    }
}
