using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class CubeDimension
    {
        public CubeDimension()
        {
            ItemXAsnCaseCubeDimension = new HashSet<ItemXAsn>();
            ItemXAsnItemCubeDimension = new HashSet<ItemXAsn>();
        }

        public int CubeDimensionId { get; set; }
        public decimal LengthMm { get; set; }
        public decimal WidthMm { get; set; }
        public decimal HeightMm { get; set; }

        public virtual ICollection<ItemXAsn> ItemXAsnCaseCubeDimension { get; set; }
        public virtual ICollection<ItemXAsn> ItemXAsnItemCubeDimension { get; set; }
    }
}
