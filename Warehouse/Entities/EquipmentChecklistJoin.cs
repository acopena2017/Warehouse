using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class EquipmentChecklistJoin
    {
        public int EquipmentChecklistId { get; set; }
        public int EquipmentChecklistItemId { get; set; }
        public int OrderPos { get; set; }
        public bool Expired { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }

        public virtual EquipmentChecklist EquipmentChecklist { get; set; }
        public virtual EquipmentChecklistItem EquipmentChecklistItem { get; set; }
    }
}
