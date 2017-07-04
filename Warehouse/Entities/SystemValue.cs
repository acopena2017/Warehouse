using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class SystemValue
    {
        public int SystemValueId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public string GroupName { get; set; }
    }
}
