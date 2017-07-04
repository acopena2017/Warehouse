using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class EquipmentType
    {
        public EquipmentType()
        {
            Equipment = new HashSet<Equipment>();
        }

        public int EquipmentTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Expired { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public bool HighEquipment { get; set; }
        public int EquipmentChecklistId { get; set; }

        public virtual ICollection<Equipment> Equipment { get; set; }
        public virtual EquipmentChecklist EquipmentChecklist { get; set; }
    }
}
