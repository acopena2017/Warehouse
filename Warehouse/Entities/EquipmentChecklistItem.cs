using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class EquipmentChecklistItem
    {
        public EquipmentChecklistItem()
        {
            EquipmentChecklistJoin = new HashSet<EquipmentChecklistJoin>();
            EquipmentCompletedChecklistItems = new HashSet<EquipmentCompletedChecklistItems>();
        }

        public int ChecklistItemId { get; set; }
        public string ItemText { get; set; }
        public string Description { get; set; }
        public bool Expired { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public int PossibleResponses { get; set; }

        public virtual ICollection<EquipmentChecklistJoin> EquipmentChecklistJoin { get; set; }
        public virtual ICollection<EquipmentCompletedChecklistItems> EquipmentCompletedChecklistItems { get; set; }
    }
}
