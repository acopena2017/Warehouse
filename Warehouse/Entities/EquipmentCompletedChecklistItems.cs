using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class EquipmentCompletedChecklistItems
    {
        public int CompletedChecklistItemId { get; set; }
        public int CompletedChecklistId { get; set; }
        public int ItemId { get; set; }
        public int Response { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }

        public virtual EquipmentCompletedChecklists CompletedChecklist { get; set; }
        public virtual EquipmentChecklistItem Item { get; set; }
    }
}
