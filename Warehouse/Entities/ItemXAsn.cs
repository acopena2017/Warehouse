using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ItemXAsn
    {
        public int ItemXAsnId { get; set; }
        public int ItemId { get; set; }
        public int AsnId { get; set; }
        public int ItemCubeDimensionId { get; set; }
        public int CaseCubeDimensionId { get; set; }
        public int ItemFaceCompositionId { get; set; }
        public int CaseFaceCompositionId { get; set; }
        public int ItemFaceTypeId { get; set; }
        public double? ItemWeightKg { get; set; }
        public int? ItemQuantityInCase { get; set; }
        public DateTime FromDate { get; set; }
        public int FromUserId { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual CubeDimension CaseCubeDimension { get; set; }
        public virtual FaceComposition CaseFaceComposition { get; set; }
        public virtual CubeDimension ItemCubeDimension { get; set; }
        public virtual FaceComposition ItemFaceComposition { get; set; }
        public virtual ItemFaceType ItemFaceType { get; set; }
        public virtual Item Item { get; set; }
    }
}
