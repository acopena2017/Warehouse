using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class Menu
    {
        public int MenuId { get; set; }
        public string GroupName { get; set; }
        public string MenuName { get; set; }
        public string HelpDescription { get; set; }
        public bool Report { get; set; }
        public string Url { get; set; }
        public int? PermissionId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? MenuGroupId { get; set; }
    }
}
