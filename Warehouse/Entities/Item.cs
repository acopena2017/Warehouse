using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class Item
    {
        public Item()
        {
            ExternalTransferItem = new HashSet<ExternalTransferItem>();
            InStockPickingHistory2 = new HashSet<InStockPickingHistory2>();
            ItemKitAtomicItem = new HashSet<ItemKit>();
            ItemKitKitItem = new HashSet<ItemKit>();
            ItemXAsn = new HashSet<ItemXAsn>();
        }

        public int ItemId { get; set; }
        public string Name { get; set; }
        public int? PalletQuantity { get; set; }
        public double? Weight { get; set; }
        public string Upc { get; set; }
        public int? SuperceededByItemId { get; set; }
        public string SuperceedList { get; set; }
        public int? MaxSuperceed { get; set; }
        public string Description { get; set; }
        public string Alternate { get; set; }
        public int? ProductId { get; set; }
        public string StructureCode { get; set; }
        public double? CubeHeight { get; set; }
        public double? CubeWidth { get; set; }
        public double? CubeDepth { get; set; }
        public decimal? AverageCostCdn { get; set; }
        public bool Reorder { get; set; }
        public int? ItemCategoryId { get; set; }
        public int? ItemStatusId { get; set; }
        public int? MovementSpeed1 { get; set; }
        public int? MovementSpeed2 { get; set; }
        public int? MinOrder { get; set; }
        public int? MaxOrder { get; set; }
        public string OriginCountry { get; set; }
        public bool Expired { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public int? LeadTimeDays { get; set; }
        public int? ItemPopularityCodeId { get; set; }
        public int? ItemCategorySalesRanking { get; set; }
        public int CaseQuantity { get; set; }
        public int ItemRanking { get; set; }
        public int ItemRankingBasis { get; set; }
        public bool IncludeInRanking { get; set; }
        public bool LockRanking { get; set; }
        public double RequiredPickingBins { get; set; }
        public double AveragePicksPerDay { get; set; }
        public decimal? AirGapMm { get; set; }
        public decimal? VaneWidthMm { get; set; }
        public int? PoPalletQuantity { get; set; }
        public string VaneCount { get; set; }
        public string Upc2 { get; set; }
        public string Upc3 { get; set; }
        public string Upc4 { get; set; }
        public string Upc5 { get; set; }
        public bool IsRemanufacturedItem { get; set; }
        public bool IsCore { get; set; }
        public int? CoreItemId { get; set; }
        public bool AutoPickRf { get; set; }
        public bool OnSale { get; set; }
        public DateTime SaleStartDate { get; set; }
        public DateTime SaleEndDate { get; set; }
        public int BuyingUnitId { get; set; }
        public string Applications { get; set; }
        public bool OverrideSkuInBin { get; set; }
        public int? RetailReserveQuantity { get; set; }
        public decimal? AverageCostUsd { get; set; }
        public int? MaxYear { get; set; }
        public int? MaxItemStack { get; set; }
        public bool KeepPackageTogether { get; set; }
        public int? NetsuiteItemExternalId { get; set; }
        public DateTime? BoomiProcessDate { get; set; }
        public string PackageParts { get; set; }
        public string UstariffCode { get; set; }
        public DateTime? LastUpdated { get; set; }

        public virtual ICollection<ExternalTransferItem> ExternalTransferItem { get; set; }
        public virtual ICollection<InStockPickingHistory2> InStockPickingHistory2 { get; set; }
        public virtual ICollection<ItemKit> ItemKitAtomicItem { get; set; }
        public virtual ICollection<ItemKit> ItemKitKitItem { get; set; }
        public virtual ICollection<ItemXAsn> ItemXAsn { get; set; }
    }
}
