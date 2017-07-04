using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ItemCategory
    {
        public ItemCategory()
        {
            ItemCategoryXAgedInventoryDiscountPeriod = new HashSet<ItemCategoryXAgedInventoryDiscountPeriod>();
        }

        public int ItemCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Heavy { get; set; }
        public double? DefectAllowance { get; set; }
        public int? EquivalentPricingItemCategoryId { get; set; }
        public double? DutyPercentage { get; set; }
        public string CategoryGroupStrings { get; set; }
        public bool System { get; set; }
        public bool Expired { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public int? MaximumSkuPerBin { get; set; }
        public string UsTarrifCode { get; set; }
        public bool? ShowVendor { get; set; }
        public int? DefaultVendorId { get; set; }
        public int? LabelMfg { get; set; }
        public int? LabelType { get; set; }
        public int? LabelMfgId { get; set; }
        public int? LabelTypeId { get; set; }
        public int? PrintOrder { get; set; }
        public int? StackOrder { get; set; }
        public int? RestockingThreshold { get; set; }
        public short SalesGroupId { get; set; }
        public int? RetailOrderBy { get; set; }
        public bool? Discontinued { get; set; }
        public bool HasPalletPricing { get; set; }
        public int SellToCountryId { get; set; }
        public bool Fullpalletreplen { get; set; }
        public bool Exforecast { get; set; }
        public bool? Antidumping { get; set; }
        public int? Targetlandedratio { get; set; }
        public string CustomsDocument { get; set; }
        public string Labeltemplate { get; set; }
        public double ExportPercentage { get; set; }
        public bool? IsSoldOnline { get; set; }
        public int? ManufacturerId { get; set; }
        public decimal DimmensionalVariance { get; set; }
        public bool? IncludeAllUnits { get; set; }
        public int? MaxDaysInventory { get; set; }
        public decimal? BinPercentageRequiredForReachTruckReplen { get; set; }
        public int DaysInventoryTolerance { get; set; }
        public bool ReplenIsActive { get; set; }
        public int? NetsuiteItemCategoryExternalId { get; set; }

        public virtual ICollection<ItemCategoryXAgedInventoryDiscountPeriod> ItemCategoryXAgedInventoryDiscountPeriod { get; set; }
    }
}
