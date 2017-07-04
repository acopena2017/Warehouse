using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class EquipmentChecklist
    {
        public EquipmentChecklist()
        {
            EquipmentChecklistJoin = new HashSet<EquipmentChecklistJoin>();
            EquipmentCompletedChecklists = new HashSet<EquipmentCompletedChecklists>();
            EquipmentType = new HashSet<EquipmentType>();
        }

        public int ChecklistId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Expired { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }

        public virtual ICollection<EquipmentChecklistJoin> EquipmentChecklistJoin { get; set; }
        public virtual ICollection<EquipmentCompletedChecklists> EquipmentCompletedChecklists { get; set; }
        public virtual ICollection<EquipmentType> EquipmentType { get; set; }
    }
}
