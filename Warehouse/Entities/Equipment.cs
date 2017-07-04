using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class Equipment
    {
        public Equipment()
        {
            EquipmentCompletedChecklists = new HashSet<EquipmentCompletedChecklists>();
        }

        public int EquipmentId { get; set; }
        public int EquipmentTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Expired { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }

        public virtual ICollection<EquipmentCompletedChecklists> EquipmentCompletedChecklists { get; set; }
        public virtual EquipmentType EquipmentType { get; set; }
    }
}
