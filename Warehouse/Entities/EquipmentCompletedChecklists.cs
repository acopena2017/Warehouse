using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class EquipmentCompletedChecklists
    {
        public EquipmentCompletedChecklists()
        {
            EquipmentCompletedChecklistItems = new HashSet<EquipmentCompletedChecklistItems>();
        }

        public int CompletedChecklistId { get; set; }
        public int SourceChecklistId { get; set; }
        public int EquipmentId { get; set; }
        public string UserName { get; set; }
        public DateTime ChecklistDate { get; set; }
        public int HourMeter { get; set; }
        public int PctCharge { get; set; }
        public string Comments { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }

        public virtual ICollection<EquipmentCompletedChecklistItems> EquipmentCompletedChecklistItems { get; set; }
        public virtual Equipment Equipment { get; set; }
        public virtual EquipmentChecklist SourceChecklist { get; set; }
    }
}
