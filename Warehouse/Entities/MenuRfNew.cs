using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class MenuRfNew
    {
        public int MenuRfId { get; set; }
        public string Name { get; set; }
        public int? Order { get; set; }
        public int? PermissionId { get; set; }
        public string FunctionName { get; set; }
        public bool? Menuflag { get; set; }
    }
}
