using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class WebAlert
    {
        public int WebAlertId { get; set; }
        public string FunctionToCall { get; set; }
        public string PermissionName { get; set; }
        public string Url { get; set; }
        public string AlertName { get; set; }
        public int WebAlertTypeId { get; set; }
    }
}
