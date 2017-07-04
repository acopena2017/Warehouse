using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class FaceComposition
    {
        public FaceComposition()
        {
            ItemXAsnCaseFaceComposition = new HashSet<ItemXAsn>();
            ItemXAsnItemFaceComposition = new HashSet<ItemXAsn>();
        }

        public int FaceCompositionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ItemXAsn> ItemXAsnCaseFaceComposition { get; set; }
        public virtual ICollection<ItemXAsn> ItemXAsnItemFaceComposition { get; set; }
    }
}
