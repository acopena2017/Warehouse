using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class XxxUserRf
    {
        public int UserRfId { get; set; }
        public int? UserId { get; set; }
        public string TerminalId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string LastFunction { get; set; }
        public string FunctionState { get; set; }
        public int? EquipmentTypeId { get; set; }
        public int WarehouseId { get; set; }
    }
}
