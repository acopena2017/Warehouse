using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Warehouse.Entities
{
    public partial class wmsContext : DbContext
    {
        public virtual DbSet<AconnexBuyer> AconnexBuyer { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressType> AddressType { get; set; }
        public virtual DbSet<AdjustmentType> AdjustmentType { get; set; }
        public virtual DbSet<AgedInventoryDiscountPeriod> AgedInventoryDiscountPeriod { get; set; }
        public virtual DbSet<BatchCountStatus> BatchCountStatus { get; set; }
        public virtual DbSet<BinBlockedType> BinBlockedType { get; set; }
        public virtual DbSet<BinPhysicalType> BinPhysicalType { get; set; }
        public virtual DbSet<BinType> BinType { get; set; }
        public virtual DbSet<BinXItemFace> BinXItemFace { get; set; }
        public virtual DbSet<BusinessSize> BusinessSize { get; set; }
        public virtual DbSet<BuyingUnit> BuyingUnit { get; set; }
        public virtual DbSet<Carrier> Carrier { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<ClientType> ClientType { get; set; }
        public virtual DbSet<CommentType> CommentType { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ContactType> ContactType { get; set; }
        public virtual DbSet<ContainerType> ContainerType { get; set; }
        public virtual DbSet<CostPlus> CostPlus { get; set; }
        public virtual DbSet<CostPlusMargin> CostPlusMargin { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CubeDimension> CubeDimension { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerLabel> CustomerLabel { get; set; }
        public virtual DbSet<CustomerOrderType> CustomerOrderType { get; set; }
        public virtual DbSet<CustomerPricelistOutputPresetSettings> CustomerPricelistOutputPresetSettings { get; set; }
        public virtual DbSet<CustomerPricelistOutputPresets> CustomerPricelistOutputPresets { get; set; }
        public virtual DbSet<CustomerPricelistOutputSettings> CustomerPricelistOutputSettings { get; set; }
        public virtual DbSet<CustomerType> CustomerType { get; set; }
        public virtual DbSet<CustomerXAddress> CustomerXAddress { get; set; }
        public virtual DbSet<CustomerXCostPlus> CustomerXCostPlus { get; set; }
        public virtual DbSet<CustomerXEdiLocationCode> CustomerXEdiLocationCode { get; set; }
        public virtual DbSet<CustomerXManufacturer> CustomerXManufacturer { get; set; }
        public virtual DbSet<CustomerXMembership> CustomerXMembership { get; set; }
        public virtual DbSet<CustomerXPricelistOutputPreset> CustomerXPricelistOutputPreset { get; set; }
        public virtual DbSet<CustomerXRegularExpression> CustomerXRegularExpression { get; set; }
        public virtual DbSet<CustomerXSalesRepresentative> CustomerXSalesRepresentative { get; set; }
        public virtual DbSet<DboUserXCustomer> DboUserXCustomer { get; set; }
        public virtual DbSet<DefectAllowance> DefectAllowance { get; set; }
        public virtual DbSet<EdiProvider> EdiProvider { get; set; }
        public virtual DbSet<Email> Email { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<EquipmentChecklist> EquipmentChecklist { get; set; }
        public virtual DbSet<EquipmentChecklistItem> EquipmentChecklistItem { get; set; }
        public virtual DbSet<EquipmentChecklistJoin> EquipmentChecklistJoin { get; set; }
        public virtual DbSet<EquipmentChecklistResp> EquipmentChecklistResp { get; set; }
        public virtual DbSet<EquipmentCompletedChecklistItems> EquipmentCompletedChecklistItems { get; set; }
        public virtual DbSet<EquipmentCompletedChecklists> EquipmentCompletedChecklists { get; set; }
        public virtual DbSet<EquipmentType> EquipmentType { get; set; }
        public virtual DbSet<Exchange> Exchange { get; set; }
        public virtual DbSet<Expiration> Expiration { get; set; }
        public virtual DbSet<ExternalTransfer> ExternalTransfer { get; set; }
        public virtual DbSet<ExternalTransferItem> ExternalTransferItem { get; set; }
        public virtual DbSet<ExternalTransferSource> ExternalTransferSource { get; set; }
        public virtual DbSet<ExternalTransferStatus> ExternalTransferStatus { get; set; }
        public virtual DbSet<FaceComposition> FaceComposition { get; set; }
        public virtual DbSet<GeneralDiscount> GeneralDiscount { get; set; }
        public virtual DbSet<GroupReplenishment> GroupReplenishment { get; set; }
        public virtual DbSet<GroupReplenishmentLine> GroupReplenishmentLine { get; set; }
        public virtual DbSet<InStockPickingHistory> InStockPickingHistory { get; set; }
        public virtual DbSet<InStockPickingHistory2> InStockPickingHistory2 { get; set; }
        public virtual DbSet<InStockPickingHistoryAll> InStockPickingHistoryAll { get; set; }
        public virtual DbSet<InventoryCountNightly> InventoryCountNightly { get; set; }
        public virtual DbSet<InventoryCountNightlyStatus> InventoryCountNightlyStatus { get; set; }
        public virtual DbSet<InvoiceSendType> InvoiceSendType { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<ItemAmazonlisting> ItemAmazonlisting { get; set; }
        public virtual DbSet<ItemCategory> ItemCategory { get; set; }
        public virtual DbSet<ItemCategoryXAgedInventoryDiscountPeriod> ItemCategoryXAgedInventoryDiscountPeriod { get; set; }
        public virtual DbSet<ItemCategoryXApprovedVendor> ItemCategoryXApprovedVendor { get; set; }
        public virtual DbSet<ItemCategoryXBinPhysicalType> ItemCategoryXBinPhysicalType { get; set; }
        public virtual DbSet<ItemCategoryXmanufacturer> ItemCategoryXmanufacturer { get; set; }
        public virtual DbSet<ItemCondition> ItemCondition { get; set; }
        public virtual DbSet<ItemFaceType> ItemFaceType { get; set; }
        public virtual DbSet<ItemKit> ItemKit { get; set; }
        public virtual DbSet<ItemPalletQuantity> ItemPalletQuantity { get; set; }
        public virtual DbSet<ItemPopularityCodes> ItemPopularityCodes { get; set; }
        public virtual DbSet<ItemStatus> ItemStatus { get; set; }
        public virtual DbSet<ItemTrending> ItemTrending { get; set; }
        public virtual DbSet<ItemXAsn> ItemXAsn { get; set; }
        public virtual DbSet<LabelType> LabelType { get; set; }
        public virtual DbSet<LabelTypeXItemCategory> LabelTypeXItemCategory { get; set; }
        public virtual DbSet<LocationType> LocationType { get; set; }
        public virtual DbSet<LogError> LogError { get; set; }
        public virtual DbSet<LtlCutoffType> LtlCutoffType { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<ManufacturerCross> ManufacturerCross { get; set; }
        public virtual DbSet<ManufacturerCrossRelational> ManufacturerCrossRelational { get; set; }
        public virtual DbSet<ManufacturerPcaousCategory> ManufacturerPcaousCategory { get; set; }
        public virtual DbSet<Membership> Membership { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MenuGroup> MenuGroup { get; set; }
        public virtual DbSet<MenuRf> MenuRf { get; set; }
        public virtual DbSet<MenuRfNew> MenuRfNew { get; set; }
        public virtual DbSet<MenuRfOld> MenuRfOld { get; set; }
        public virtual DbSet<MenuRfXWarehouse> MenuRfXWarehouse { get; set; }
        public virtual DbSet<PackagingType> PackagingType { get; set; }
        public virtual DbSet<PartSpecifics> PartSpecifics { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<PickingOrderStatus> PickingOrderStatus { get; set; }
        public virtual DbSet<PickingReason> PickingReason { get; set; }
        public virtual DbSet<PickingType> PickingType { get; set; }
        public virtual DbSet<PoInvoiceStatus> PoInvoiceStatus { get; set; }
        public virtual DbSet<PoInvoiceType> PoInvoiceType { get; set; }
        public virtual DbSet<PoStatus> PoStatus { get; set; }
        public virtual DbSet<PriceListOutputRowDefinition> PriceListOutputRowDefinition { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProvinceState> ProvinceState { get; set; }
        public virtual DbSet<QueuingConfiguration> QueuingConfiguration { get; set; }
        public virtual DbSet<ReplenishmentOrderDiscrepancyType> ReplenishmentOrderDiscrepancyType { get; set; }
        public virtual DbSet<ReplenishmentOrderType> ReplenishmentOrderType { get; set; }
        public virtual DbSet<RgaResult> RgaResult { get; set; }
        public virtual DbSet<RgaStatus> RgaStatus { get; set; }
        public virtual DbSet<RoStatus> RoStatus { get; set; }
        public virtual DbSet<SalesChannel> SalesChannel { get; set; }
        public virtual DbSet<SalesPartner> SalesPartner { get; set; }
        public virtual DbSet<SalesPaymentMethod> SalesPaymentMethod { get; set; }
        public virtual DbSet<SalesPaymentXSoInvoiceReferenceType> SalesPaymentXSoInvoiceReferenceType { get; set; }
        public virtual DbSet<SalesQualification> SalesQualification { get; set; }
        public virtual DbSet<SalesRepresentative> SalesRepresentative { get; set; }
        public virtual DbSet<SalesRepresentativeType> SalesRepresentativeType { get; set; }
        public virtual DbSet<SalesRepresentativeXAddress> SalesRepresentativeXAddress { get; set; }
        public virtual DbSet<SellToCountry> SellToCountry { get; set; }
        public virtual DbSet<ShippingCompany> ShippingCompany { get; set; }
        public virtual DbSet<ShippingDeliveryDates> ShippingDeliveryDates { get; set; }
        public virtual DbSet<ShippingDocumentEditotals> ShippingDocumentEditotals { get; set; }
        public virtual DbSet<ShippingQuote> ShippingQuote { get; set; }
        public virtual DbSet<ShippingQuoteEntity> ShippingQuoteEntity { get; set; }
        public virtual DbSet<ShippingQuoteEntityType> ShippingQuoteEntityType { get; set; }
        public virtual DbSet<ShippingQuoteEntityValueType> ShippingQuoteEntityValueType { get; set; }
        public virtual DbSet<ShippingQuoteLine> ShippingQuoteLine { get; set; }
        public virtual DbSet<ShippingQuoteLineEntity> ShippingQuoteLineEntity { get; set; }
        public virtual DbSet<ShippingQuoteLineXCity> ShippingQuoteLineXCity { get; set; }
        public virtual DbSet<ShippingQuoteLineXProvinceState> ShippingQuoteLineXProvinceState { get; set; }
        public virtual DbSet<ShippingQuoteSchema> ShippingQuoteSchema { get; set; }
        public virtual DbSet<ShippingQuoteStructure> ShippingQuoteStructure { get; set; }
        public virtual DbSet<ShippingQuoteType> ShippingQuoteType { get; set; }
        public virtual DbSet<ShippingRate> ShippingRate { get; set; }
        public virtual DbSet<SoInvoiceStatus> SoInvoiceStatus { get; set; }
        public virtual DbSet<SoStatus> SoStatus { get; set; }
        public virtual DbSet<SystemValue> SystemValue { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TaskPriority> TaskPriority { get; set; }
        public virtual DbSet<TaskStatus> TaskStatus { get; set; }
        public virtual DbSet<TaskType> TaskType { get; set; }
        public virtual DbSet<Tax> Tax { get; set; }
        public virtual DbSet<TaxCode> TaxCode { get; set; }
        public virtual DbSet<TaxCodeXTax> TaxCodeXTax { get; set; }
        public virtual DbSet<Terms> Terms { get; set; }
        public virtual DbSet<TransferType> TransferType { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserPriceListOutput> UserPriceListOutput { get; set; }
        public virtual DbSet<UserPriceListOutputDetail> UserPriceListOutputDetail { get; set; }
        public virtual DbSet<UspsorderParts> UspsorderParts { get; set; }
        public virtual DbSet<Uspsorders> Uspsorders { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<VendorType> VendorType { get; set; }
        public virtual DbSet<VendorTypeXPoInvoiceType> VendorTypeXPoInvoiceType { get; set; }
        public virtual DbSet<VendorXAddress> VendorXAddress { get; set; }
        public virtual DbSet<VendorXItem> VendorXItem { get; set; }
        public virtual DbSet<VendorXManufacturer> VendorXManufacturer { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<WebAlert> WebAlert { get; set; }
        public virtual DbSet<WebAlertType> WebAlertType { get; set; }
        public virtual DbSet<WmsBusiness> WmsBusiness { get; set; }
        public virtual DbSet<WmsBusinessXCustomer> WmsBusinessXCustomer { get; set; }
        public virtual DbSet<WmsBusinessXVendor> WmsBusinessXVendor { get; set; }
        public virtual DbSet<XxxUserRf> XxxUserRf { get; set; }
        public virtual DbSet<Zone> Zone { get; set; }

        // Unable to generate entity type for table 'dbo.outofstockhistorytotal'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_ExecutionLog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SalesTwelveMonths'. Please see the warning messages.
        // Unable to generate entity type for table 'log.ReportsForLogging'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ItemHOT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.menu_rf_x_warehouse_old'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.category_x_manufacturer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.xxx_manufacturer_cross_import'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.4WMS_ProductDaysAvailable_delete'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.qwerty'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.4WMS_PartsDaysAvailable_delete'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.deletion'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.deletionold'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.item_comments'. Please see the warning messages.
        // Unable to generate entity type for table 'log.ReportExecution'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.USPSAPIInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.USPSRecreditTransactions'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WMSApplications'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.outofstockhistory'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source=svr-dev-db;Initial Catalog=wmsAllDB;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AconnexBuyer>(entity =>
            {
                entity.HasKey(e => new { e.AconnexBuyerId, e.BuyerId, e.CustomerId })
                    .HasName("pk_aconnex_buyer");

                entity.ToTable("aconnex_buyer");

                entity.Property(e => e.AconnexBuyerId)
                    .HasColumnName("aconnex_buyer_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BuyerId)
                    .HasColumnName("buyer_id")
                    .HasMaxLength(30);

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.AconnexBuyer)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_aconnex_buyer_02");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("address");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.Address1)
                    .HasColumnName("address_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Address2)
                    .HasColumnName("address_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Address3)
                    .HasColumnName("address_3")
                    .HasMaxLength(255);

                entity.Property(e => e.AddressTypeId).HasColumnName("address_type_id");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(255);

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(255);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.Default)
                    .HasColumnName("default")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProvinceStateIdDeprecated).HasColumnName("province_state_id_deprecated");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(255);

                entity.Property(e => e.TableId).HasColumnName("table_id");

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasMaxLength(255);

                entity.HasOne(d => d.CityNavigation)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("fk_address_20");
            });

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.ToTable("address_type");

                entity.Property(e => e.AddressTypeId).HasColumnName("address_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AdjustmentType>(entity =>
            {
                entity.ToTable("adjustment_type");

                entity.Property(e => e.AdjustmentTypeId).HasColumnName("adjustment_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AgedInventoryDiscountPeriod>(entity =>
            {
                entity.ToTable("aged_inventory_discount_period");

                entity.Property(e => e.AgedInventoryDiscountPeriodId).HasColumnName("aged_inventory_discount_period_id");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromDate)
                    .HasColumnName("from_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PeriodMonths).HasColumnName("period_months");
            });

            modelBuilder.Entity<BatchCountStatus>(entity =>
            {
                entity.ToTable("batch_count_status");

                entity.Property(e => e.BatchCountStatusId).HasColumnName("batch_count_status_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BinBlockedType>(entity =>
            {
                entity.ToTable("bin_blocked_type");

                entity.Property(e => e.BinBlockedTypeId).HasColumnName("bin_blocked_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BinPhysicalType>(entity =>
            {
                entity.ToTable("bin_physical_type");

                entity.Property(e => e.BinPhysicalTypeId).HasColumnName("bin_physical_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.MultipleFaces)
                    .HasColumnName("multiple_faces")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasColumnName("update_user");
            });

            modelBuilder.Entity<BinType>(entity =>
            {
                entity.ToTable("bin_type");

                entity.Property(e => e.BinTypeId).HasColumnName("bin_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BinXItemFace>(entity =>
            {
                entity.ToTable("bin_x_item_face");

                entity.Property(e => e.BinXItemFaceId).HasColumnName("bin_x_item_face_id");

                entity.Property(e => e.BinId).HasColumnName("bin_id");

                entity.Property(e => e.ClearDate)
                    .HasColumnName("clear_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromDate)
                    .HasColumnName("from_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsPalletBin).HasColumnName("is_pallet_bin");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemXAsnId).HasColumnName("item_x_asn_id");

                entity.Property(e => e.ManualOverride).HasColumnName("manual_override");

                entity.Property(e => e.StackAlignment).HasColumnName("stack_alignment");
            });

            modelBuilder.Entity<BusinessSize>(entity =>
            {
                entity.ToTable("business_size");

                entity.Property(e => e.BusinessSizeId).HasColumnName("business_size_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BuyingUnit>(entity =>
            {
                entity.ToTable("buying_unit");

                entity.Property(e => e.BuyingUnitId)
                    .HasColumnName("buying_unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired).HasColumnName("expired");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System).HasColumnName("system");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasColumnName("update_user");
            });

            modelBuilder.Entity<Carrier>(entity =>
            {
                entity.ToTable("carrier");

                entity.Property(e => e.CarrierId).HasColumnName("carrier_id");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(255);

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Skids)
                    .HasColumnName("skids")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorId)
                    .HasColumnName("vendor_id")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.ProvinceStateId).HasColumnName("province_state_id");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasColumnName("update_user");

                entity.HasOne(d => d.ProvinceState)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.ProvinceStateId)
                    .HasConstraintName("fk_city_02");
            });

            modelBuilder.Entity<ClientType>(entity =>
            {
                entity.ToTable("client_type");

                entity.Property(e => e.ClientTypeId).HasColumnName("client_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CommentType>(entity =>
            {
                entity.ToTable("comment_type");

                entity.Property(e => e.CommentTypeId).HasColumnName("comment_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("contact");

                entity.HasIndex(e => new { e.TableId, e.ContactTypeId })
                    .HasName("contact_03_04");

                entity.Property(e => e.ContactId).HasColumnName("contact_id");

                entity.Property(e => e.ContactTypeId).HasColumnName("contact_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.Default)
                    .HasColumnName("default")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(255);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(255);

                entity.Property(e => e.Salutation)
                    .HasColumnName("salutation")
                    .HasMaxLength(255);

                entity.Property(e => e.TableId).HasColumnName("table_id");

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ContactType>(entity =>
            {
                entity.ToTable("contact_type");

                entity.Property(e => e.ContactTypeId).HasColumnName("contact_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ContainerType>(entity =>
            {
                entity.ToTable("container_type");

                entity.Property(e => e.ContainerTypeId).HasColumnName("container_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxVolume)
                    .HasColumnName("max_volume")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxWeight)
                    .HasColumnName("max_weight")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CostPlus>(entity =>
            {
                entity.ToTable("cost_plus");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_name")
                    .IsUnique();

                entity.Property(e => e.CostPlusId).HasColumnName("cost_plus_id");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndUserId).HasColumnName("end_user_id");

                entity.Property(e => e.FromDate)
                    .HasColumnName("from_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromUserId).HasColumnName("from_user_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CostPlusMargin>(entity =>
            {
                entity.ToTable("cost_plus_margin");

                entity.Property(e => e.CostPlusMarginId).HasColumnName("cost_plus_margin_id");

                entity.Property(e => e.CostPlusId).HasColumnName("cost_plus_id");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndUserId).HasColumnName("end_user_id");

                entity.Property(e => e.FromDate)
                    .HasColumnName("from_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromUserId).HasColumnName("from_user_id");

                entity.Property(e => e.Margin)
                    .HasColumnName("margin")
                    .HasColumnType("decimal");

                entity.HasOne(d => d.CostPlus)
                    .WithMany(p => p.CostPlusMargin)
                    .HasForeignKey(d => d.CostPlusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_cost_plus_margin__cost_plus");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsoAbbr2)
                    .HasColumnName("iso_abbr_2")
                    .HasMaxLength(2);

                entity.Property(e => e.IsoAbbr3)
                    .HasColumnName("iso_abbr_3")
                    .HasMaxLength(3);

                entity.Property(e => e.IsoCountryCode).HasColumnName("iso_country_code");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CubeDimension>(entity =>
            {
                entity.ToTable("cube_dimension");

                entity.Property(e => e.CubeDimensionId).HasColumnName("cube_dimension_id");

                entity.Property(e => e.HeightMm)
                    .HasColumnName("height_mm")
                    .HasColumnType("decimal");

                entity.Property(e => e.LengthMm)
                    .HasColumnName("length_mm")
                    .HasColumnType("decimal");

                entity.Property(e => e.WidthMm)
                    .HasColumnName("width_mm")
                    .HasColumnType("decimal");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.HasIndex(e => e.ExcludeForecast)
                    .HasName("idx_customer_46");

                entity.HasIndex(e => e.UseDirectShip)
                    .HasName("rdx_customer_34");

                entity.HasIndex(e => new { e.Number, e.CustomerTypeId })
                    .HasName("idx_customer_02_04");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.AnniversaryDate)
                    .HasColumnName("anniversary_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BlockPalletPricing)
                    .HasColumnName("block_pallet_pricing")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.BusinessSizeId).HasColumnName("business_size_id");

                entity.Property(e => e.BuyoutBinId).HasColumnName("buyoutBinId");

                entity.Property(e => e.CanVerifyAndShip).HasColumnName("canVerifyAndShip");

                entity.Property(e => e.CcInfo)
                    .HasColumnName("cc_info")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("null");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(255);

                entity.Property(e => e.ClientTypeId)
                    .HasColumnName("client_type_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.CreditHold)
                    .HasColumnName("credit_hold")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreditLimit)
                    .HasColumnName("credit_limit")
                    .HasColumnType("money");

                entity.Property(e => e.Currency)
                    .HasColumnName("currency")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerTypeId)
                    .HasColumnName("customer_type_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DefaultWarehouse)
                    .HasColumnName("default_warehouse")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.EdiProviderId).HasColumnName("edi_provider_id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.EmailOnQueue)
                    .HasColumnName("emailOnQueue")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExcludeForecast).HasDefaultValueSql("0");

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExternalStoreFront)
                    .HasColumnName("externalStoreFront")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExternalTransferBinId).HasColumnName("externalTransferBinId");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(255);

                entity.Property(e => e.FederalNumber)
                    .HasColumnName("federal_number")
                    .HasMaxLength(255);

                entity.Property(e => e.GstNumber)
                    .HasColumnName("gst_number")
                    .HasMaxLength(255);

                entity.Property(e => e.HoldBackOrders)
                    .HasColumnName("hold_back_orders")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Intercompany)
                    .HasColumnName("intercompany")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InvoiceSendTypeId)
                    .HasColumnName("invoice_send_type_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsAutoPriority).HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasMaxLength(255);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(255);

                entity.Property(e => e.ProvinceStateId).HasColumnName("province_state_id");

                entity.Property(e => e.PstNumber)
                    .HasColumnName("pst_number")
                    .HasMaxLength(255);

                entity.Property(e => e.SalesQualificationId).HasColumnName("sales_qualification_id");

                entity.Property(e => e.ScheduledDelivery)
                    .HasColumnName("scheduled_delivery")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SendPartialShipments)
                    .HasColumnName("send_partial_shipments")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TaxCodeId).HasColumnName("tax_code_id");

                entity.Property(e => e.TermsId).HasColumnName("terms_id");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UseDirectShip)
                    .HasColumnName("use_direct_ship")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UsesQuickpicks)
                    .HasColumnName("uses_quickpicks")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.EdiProvider)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.EdiProviderId)
                    .HasConstraintName("fk_customer_38");
            });

            modelBuilder.Entity<CustomerLabel>(entity =>
            {
                entity.ToTable("customer_label");

                entity.Property(e => e.CustomerLabelId).HasColumnName("customer_label_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Expired).HasColumnName("expired");

                entity.Property(e => e.LabelFilename)
                    .HasColumnName("label_filename")
                    .HasMaxLength(255);

                entity.Property(e => e.LabelPrinterId).HasColumnName("label_printer_id");

                entity.Property(e => e.LabelTypeId).HasColumnName("label_type_id");

                entity.Property(e => e.WmsLabel)
                    .HasColumnName("WMS_Label")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CustomerOrderType>(entity =>
            {
                entity.ToTable("customer_order_type");

                entity.Property(e => e.CustomerOrderTypeId).HasColumnName("customer_order_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CustomerPricelistOutputPresetSettings>(entity =>
            {
                entity.HasKey(e => e.SettingId)
                    .HasName("pk_customer_pricelist_output_preset_settings");

                entity.ToTable("customer_pricelist_output_preset_settings");

                entity.Property(e => e.SettingId).HasColumnName("setting_id");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ManufacturerId)
                    .HasColumnName("manufacturer_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PresetId)
                    .HasColumnName("preset_id")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CustomerPricelistOutputPresets>(entity =>
            {
                entity.HasKey(e => e.PresetId)
                    .HasName("pk_customer_pricelist_output_presets");

                entity.ToTable("customer_pricelist_output_presets");

                entity.Property(e => e.PresetId).HasColumnName("preset_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PresetDescription)
                    .HasColumnName("preset_description")
                    .HasMaxLength(255);

                entity.Property(e => e.PresetName)
                    .HasColumnName("preset_name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasColumnName("update_user");
            });

            modelBuilder.Entity<CustomerPricelistOutputSettings>(entity =>
            {
                entity.HasKey(e => e.SettingId)
                    .HasName("pk_customer_pricelist_output_settings");

                entity.ToTable("customer_pricelist_output_settings");

                entity.Property(e => e.SettingId).HasColumnName("setting_id");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ManufacturerId)
                    .HasColumnName("manufacturer_id")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CustomerType>(entity =>
            {
                entity.ToTable("customer_type");

                entity.Property(e => e.CustomerTypeId).HasColumnName("customer_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CustomerXAddress>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.AddressId, e.CustomerXAddressId })
                    .HasName("pk_customer_x_address");

                entity.ToTable("customer_x_address");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.CustomerXAddressId)
                    .HasColumnName("customer_x_address_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CustomerXCostPlus>(entity =>
            {
                entity.ToTable("customer_x_cost_plus");

                entity.Property(e => e.CustomerXCostPlusId).HasColumnName("customer_x_cost_plus_id");

                entity.Property(e => e.CostPlusId).HasColumnName("cost_plus_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndUserId).HasColumnName("end_user_id");

                entity.Property(e => e.FromDate)
                    .HasColumnName("from_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromUserId).HasColumnName("from_user_id");

                entity.HasOne(d => d.CostPlus)
                    .WithMany(p => p.CustomerXCostPlus)
                    .HasForeignKey(d => d.CostPlusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_customer_x_cost_plus__cost_plus");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerXCostPlus)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_customer_x_cost_plus__customer");
            });

            modelBuilder.Entity<CustomerXEdiLocationCode>(entity =>
            {
                entity.ToTable("customer_x_edi_location_code");

                entity.Property(e => e.CustomerXEdiLocationCodeId).HasColumnName("customer_x_edi_location_code_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.EdiProviderId).HasColumnName("edi_provider_id");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("location_code")
                    .HasColumnType("varchar(10)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerXEdiLocationCode)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fk_customer_x_edi_location_code_02");

                entity.HasOne(d => d.EdiProvider)
                    .WithMany(p => p.CustomerXEdiLocationCode)
                    .HasForeignKey(d => d.EdiProviderId)
                    .HasConstraintName("fk_customer_x_edi_location_code_03");
            });

            modelBuilder.Entity<CustomerXManufacturer>(entity =>
            {
                entity.HasKey(e => new { e.ManufacturerId, e.CustomerId })
                    .HasName("pk_customer_x_manufacturer");

                entity.ToTable("customer_x_manufacturer");

                entity.Property(e => e.ManufacturerId)
                    .HasColumnName("manufacturer_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CustomerXMembership>(entity =>
            {
                entity.ToTable("customer_x_membership");

                entity.Property(e => e.CustomerXMembershipId).HasColumnName("customer_x_membership_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MembershipId)
                    .HasColumnName("membership_id")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CustomerXPricelistOutputPreset>(entity =>
            {
                entity.HasKey(e => e.CustomerXPresetId)
                    .HasName("pk_customer_x_pricelist_output_preset");

                entity.ToTable("customer_x_pricelist_output_preset");

                entity.HasIndex(e => new { e.CustomerId, e.PresetId })
                    .HasName("idx_customer_x_pricelist_output_preset_02_03");

                entity.Property(e => e.CustomerXPresetId).HasColumnName("customer_x_preset_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PresetId)
                    .HasColumnName("preset_id")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CustomerXRegularExpression>(entity =>
            {
                entity.ToTable("customer_x_regular_expression");

                entity.HasIndex(e => new { e.CustomerId, e.CustomerOrderTypeId })
                    .HasName("idx_customer_x_regular_expression_02_06");

                entity.Property(e => e.CustomerXRegularExpressionId).HasColumnName("customer_x_regular_expression_id");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CustomerOrderTypeId)
                    .HasColumnName("customer_order_type_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LineExpression)
                    .HasColumnName("line_expression")
                    .HasMaxLength(255);

                entity.Property(e => e.PartExpression)
                    .HasColumnName("part_expression")
                    .HasMaxLength(255);

                entity.Property(e => e.QuantityExpression)
                    .HasColumnName("quantity_expression")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CustomerXSalesRepresentative>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.SalesRepresentativeId })
                    .HasName("pk_customer_x_sales_representative");

                entity.ToTable("customer_x_sales_representative");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SalesRepresentativeId)
                    .HasColumnName("sales_representative_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CommissionPercentage)
                    .HasColumnName("commission_percentage")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DboUserXCustomer>(entity =>
            {
                entity.HasKey(e => e.UserXCustomerId)
                    .HasName("pk_user_x_customer");

                entity.ToTable("dbo.user_x_customer");

                entity.Property(e => e.UserXCustomerId).HasColumnName("user_x_customer_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<DefectAllowance>(entity =>
            {
                entity.HasKey(e => new { e.ItemCategoryId, e.TableId, e.TableName })
                    .HasName("pk_defect_allowance");

                entity.ToTable("defect_allowance");

                entity.Property(e => e.ItemCategoryId)
                    .HasColumnName("item_category_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TableId)
                    .HasColumnName("table_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DefectAllowanceId)
                    .HasColumnName("defect_allowance_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Percent)
                    .HasColumnName("percent")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EdiProvider>(entity =>
            {
                entity.ToTable("edi_provider");

                entity.Property(e => e.EdiProviderId).HasColumnName("edi_provider_id");

                entity.Property(e => e.EdiDescription)
                    .IsRequired()
                    .HasColumnName("edi_description")
                    .HasMaxLength(255);

                entity.Property(e => e.EdiName)
                    .IsRequired()
                    .HasColumnName("edi_name")
                    .HasMaxLength(255);

                entity.Property(e => e.HasLocationCodes).HasColumnName("has_location_codes");
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.ToTable("email");

                entity.Property(e => e.EmailId).HasColumnName("email_id");

                entity.Property(e => e.Bcc)
                    .HasColumnName("bcc")
                    .HasMaxLength(255);

                entity.Property(e => e.Body)
                    .HasColumnName("body")
                    .HasColumnType("ntext");

                entity.Property(e => e.Cc)
                    .HasColumnName("cc")
                    .HasMaxLength(255);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EntityId)
                    .HasColumnName("entity_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EntityName)
                    .HasColumnName("entity_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(255);

                entity.Property(e => e.To)
                    .HasColumnName("to")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.ToTable("equipment");

                entity.Property(e => e.EquipmentId).HasColumnName("equipment_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EquipmentTypeId).HasColumnName("equipment_type_id");

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.EquipmentType)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.EquipmentTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_equipment_equipmenttype");
            });

            modelBuilder.Entity<EquipmentChecklist>(entity =>
            {
                entity.HasKey(e => e.ChecklistId)
                    .HasName("checklist_id");

                entity.ToTable("equipment_checklist");

                entity.Property(e => e.ChecklistId).HasColumnName("checklist_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EquipmentChecklistItem>(entity =>
            {
                entity.HasKey(e => e.ChecklistItemId)
                    .HasName("checklist_item_id");

                entity.ToTable("equipment_checklist_item");

                entity.Property(e => e.ChecklistItemId).HasColumnName("checklist_item_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemText)
                    .IsRequired()
                    .HasColumnName("item_text")
                    .HasMaxLength(255);

                entity.Property(e => e.PossibleResponses)
                    .HasColumnName("possible_responses")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EquipmentChecklistJoin>(entity =>
            {
                entity.HasKey(e => new { e.EquipmentChecklistId, e.EquipmentChecklistItemId })
                    .HasName("PK_equipment_checklist_join");

                entity.ToTable("equipment_checklist_join");

                entity.Property(e => e.EquipmentChecklistId).HasColumnName("equipment_checklist_id");

                entity.Property(e => e.EquipmentChecklistItemId).HasColumnName("equipment_checklist_item_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrderPos).HasColumnName("orderPos");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.EquipmentChecklist)
                    .WithMany(p => p.EquipmentChecklistJoin)
                    .HasForeignKey(d => d.EquipmentChecklistId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_equipmentchecklistjoin_equipmentchecklist");

                entity.HasOne(d => d.EquipmentChecklistItem)
                    .WithMany(p => p.EquipmentChecklistJoin)
                    .HasForeignKey(d => d.EquipmentChecklistItemId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_equipmentchecklistjoin_equipmentchecklistitem");
            });

            modelBuilder.Entity<EquipmentChecklistResp>(entity =>
            {
                entity.HasKey(e => e.ChecklistRespId)
                    .HasName("checklist_resp_id");

                entity.ToTable("equipment_checklist_resp");

                entity.Property(e => e.ChecklistRespId).HasColumnName("checklist_resp_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ResponseCode).HasColumnName("response_code");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EquipmentCompletedChecklistItems>(entity =>
            {
                entity.HasKey(e => e.CompletedChecklistItemId)
                    .HasName("completed_checklist_item_id");

                entity.ToTable("equipment_completed_checklist_items");

                entity.Property(e => e.CompletedChecklistItemId).HasColumnName("completed_checklist_item_id");

                entity.Property(e => e.CompletedChecklistId).HasColumnName("completed_checklist_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.Response).HasColumnName("response");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.CompletedChecklist)
                    .WithMany(p => p.EquipmentCompletedChecklistItems)
                    .HasForeignKey(d => d.CompletedChecklistId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_equipmentcompletedchecklistitem_completedchecklist");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.EquipmentCompletedChecklistItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_equipmentcompletedchecklistitem_checklistitem");
            });

            modelBuilder.Entity<EquipmentCompletedChecklists>(entity =>
            {
                entity.HasKey(e => e.CompletedChecklistId)
                    .HasName("completed_checklist_id");

                entity.ToTable("equipment_completed_checklists");

                entity.Property(e => e.CompletedChecklistId).HasColumnName("completed_checklist_id");

                entity.Property(e => e.ChecklistDate)
                    .HasColumnName("checklist_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(512);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EquipmentId).HasColumnName("equipment_id");

                entity.Property(e => e.HourMeter).HasColumnName("hour_meter");

                entity.Property(e => e.PctCharge).HasColumnName("pct_charge");

                entity.Property(e => e.SourceChecklistId).HasColumnName("source_checklist_id");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.EquipmentCompletedChecklists)
                    .HasForeignKey(d => d.EquipmentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_equipmentcompletedchecklists_equipment");

                entity.HasOne(d => d.SourceChecklist)
                    .WithMany(p => p.EquipmentCompletedChecklists)
                    .HasForeignKey(d => d.SourceChecklistId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_equipmentcompletedchecklists_equipmentchecklist");
            });

            modelBuilder.Entity<EquipmentType>(entity =>
            {
                entity.ToTable("equipment_type");

                entity.Property(e => e.EquipmentTypeId).HasColumnName("equipment_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EquipmentChecklistId)
                    .HasColumnName("equipment_checklist_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HighEquipment)
                    .HasColumnName("high_equipment")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.EquipmentChecklist)
                    .WithMany(p => p.EquipmentType)
                    .HasForeignKey(d => d.EquipmentChecklistId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_equipmenttype_equipmentchecklist");
            });

            modelBuilder.Entity<Exchange>(entity =>
            {
                entity.ToTable("exchange");

                entity.HasIndex(e => new { e.Year, e.Month })
                    .HasName("idx_exchange_02_03");

                entity.Property(e => e.ExchangeId).HasColumnName("exchange_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Expiration>(entity =>
            {
                entity.ToTable("expiration");

                entity.Property(e => e.ExpirationId).HasColumnName("expiration_id");

                entity.Property(e => e.Entity)
                    .HasColumnName("entity")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityId)
                    .HasColumnName("entity_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("expiration_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(255);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ExternalTransfer>(entity =>
            {
                entity.Property(e => e.CancelDate).HasColumnType("datetime");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DriveDate).HasColumnType("datetime");

                entity.Property(e => e.IsForReserveOrder).HasDefaultValueSql("0");

                entity.Property(e => e.PickedDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreateUser)
                    .WithMany(p => p.ExternalTransferCreateUser)
                    .HasForeignKey(d => d.CreateUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExternalTransfer_user");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ExternalTransfer)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExternalTransfer_customer");

                entity.HasOne(d => d.DriverUser)
                    .WithMany(p => p.ExternalTransferDriverUser)
                    .HasForeignKey(d => d.DriverUserId)
                    .HasConstraintName("FK_ExternalTransfer_user4");

                entity.HasOne(d => d.PickUser)
                    .WithMany(p => p.ExternalTransferPickUser)
                    .HasForeignKey(d => d.PickUserId)
                    .HasConstraintName("FK_ExternalTransfer_user1");

                entity.HasOne(d => d.ReceiveUser)
                    .WithMany(p => p.ExternalTransferReceiveUser)
                    .HasForeignKey(d => d.ReceiveUserId)
                    .HasConstraintName("FK_ExternalTransfer_user2");

                entity.HasOne(d => d.RequestUser)
                    .WithMany(p => p.ExternalTransferRequestUser)
                    .HasForeignKey(d => d.RequestUserId)
                    .HasConstraintName("FK_ExternalTransfer_user3");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ExternalTransfer)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExternalTransfer_ExternalTransferStatus");
            });

            modelBuilder.Entity<ExternalTransferItem>(entity =>
            {
                entity.HasOne(d => d.ExternalTransfer)
                    .WithMany(p => p.ExternalTransferItem)
                    .HasForeignKey(d => d.ExternalTransferId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExternalTransferItem_ExternalTransfer");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ExternalTransferItem)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExternalTransferItem_item");
            });

            modelBuilder.Entity<ExternalTransferSource>(entity =>
            {
                entity.Property(e => e.PickedDate).HasColumnType("datetime");

                entity.Property(e => e.PickedQuantity).HasDefaultValueSql("0");

                entity.Property(e => e.ReasonId).HasDefaultValueSql("0");

                entity.HasOne(d => d.ExternalTransferItem)
                    .WithMany(p => p.ExternalTransferSource)
                    .HasForeignKey(d => d.ExternalTransferItemId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExternalTransferSource_ExternalTransferItem");
            });

            modelBuilder.Entity<ExternalTransferStatus>(entity =>
            {
                entity.Property(e => e.ExternalTransferStatusId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FaceComposition>(entity =>
            {
                entity.ToTable("face_composition");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_face_composition_name")
                    .IsUnique();

                entity.Property(e => e.FaceCompositionId).HasColumnName("face_composition_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GeneralDiscount>(entity =>
            {
                entity.HasKey(e => new { e.ItemCategoryId, e.TableId, e.TableName })
                    .HasName("pk_general_discount");

                entity.ToTable("general_discount");

                entity.Property(e => e.ItemCategoryId)
                    .HasColumnName("item_category_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TableId)
                    .HasColumnName("table_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GeneralDiscountId)
                    .HasColumnName("general_discount_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Percent)
                    .HasColumnName("percent")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GroupReplenishment>(entity =>
            {
                entity.ToTable("group_replenishment");

                entity.Property(e => e.GroupReplenishmentId).HasColumnName("group_replenishment_id");

                entity.Property(e => e.Closed).HasColumnName("closed");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PalletId).HasColumnName("pallet_id");
            });

            modelBuilder.Entity<GroupReplenishmentLine>(entity =>
            {
                entity.ToTable("group_replenishment_line");

                entity.Property(e => e.GroupReplenishmentLineId).HasColumnName("group_replenishment_line_id");

                entity.Property(e => e.GroupReplenishmentId).HasColumnName("group_replenishment_id");

                entity.Property(e => e.ReplenishmentOrderLineId).HasColumnName("replenishment_order_line_id");

                entity.Property(e => e.ReplenishmentType)
                    .IsRequired()
                    .HasColumnName("replenishment_type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InStockPickingHistory>(entity =>
            {
                entity.HasIndex(e => new { e.ItemId, e.StockDate })
                    .HasName("idx01");

                entity.Property(e => e.StockDate).HasColumnType("date");
            });

            modelBuilder.Entity<InStockPickingHistory2>(entity =>
            {
                entity.HasKey(e => e.InStockPickingHistoryId)
                    .HasName("PK_InStockPickingHistory2");

                entity.Property(e => e.StockDate).HasColumnType("datetime");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InStockPickingHistory2)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InStockPickingHistory2_item");

                entity.HasOne(d => d.SalesChannel)
                    .WithMany(p => p.InStockPickingHistory2)
                    .HasForeignKey(d => d.SalesChannelId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InStockPickingHistory2_SalesChannel");
            });

            modelBuilder.Entity<InStockPickingHistoryAll>(entity =>
            {
                entity.HasKey(e => e.InStockPickingHistoryId)
                    .HasName("PK_InStockPickingHistoryAll");

                entity.Property(e => e.StockDate).HasColumnType("date");
            });

            modelBuilder.Entity<InventoryCountNightly>(entity =>
            {
                entity.HasKey(e => e.NsInternalId)
                    .HasName("PK__Inventor__746F9755DB8B40C3");

                entity.ToTable("Inventory_Count_Nightly");

                entity.Property(e => e.NsInternalId)
                    .HasColumnName("NsInternalID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasColumnType("varchar(225)");

                entity.Property(e => e.NsCount).HasColumnType("decimal");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<InventoryCountNightlyStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__Inventor__C8EE2043B45C6B4B");

                entity.ToTable("Inventory_Count_Nightly_Status");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Status).HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<InvoiceSendType>(entity =>
            {
                entity.ToTable("invoice_send_type");

                entity.Property(e => e.InvoiceSendTypeId).HasColumnName("invoice_send_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("item");

                entity.HasIndex(e => e.ItemCategoryId)
                    .HasName("idx_item_18");

                entity.HasIndex(e => e.ItemPopularityCodeId)
                    .HasName("idx_item_23");

                entity.HasIndex(e => e.ItemStatusId)
                    .HasName("idx_item_19");

                entity.HasIndex(e => e.LockRanking)
                    .HasName("idx_item_37");

                entity.HasIndex(e => e.MaxSuperceed)
                    .HasName("rdx_item_08");

                entity.HasIndex(e => e.Name)
                    .HasName("uk_item_02")
                    .IsUnique();

                entity.HasIndex(e => e.OnSale)
                    .HasName("idx_item_100");

                entity.HasIndex(e => e.SuperceededByItemId)
                    .HasName("idx_item_06");

                entity.HasIndex(e => e.Upc)
                    .HasName("rdx_item_05");

                entity.HasIndex(e => e.Upc2)
                    .HasName("rdx_item_46");

                entity.HasIndex(e => e.Upc3)
                    .HasName("rdx_item_47");

                entity.HasIndex(e => e.Upc4)
                    .HasName("rdx_item_48");

                entity.HasIndex(e => new { e.ItemId, e.SuperceededByItemId, e.ItemStatusId })
                    .HasName("idx_item_101");

                entity.HasIndex(e => new { e.Name, e.ItemId, e.RetailReserveQuantity, e.ItemCategoryId })
                    .HasName("idx_retailreserve");

                entity.HasIndex(e => new { e.Alternate, e.Applications, e.ItemId, e.Description, e.Name, e.ItemCategoryId, e.ItemStatusId })
                    .HasName("idx_categorystatus");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.AirGapMm)
                    .HasColumnName("air_gap_mm")
                    .HasColumnType("decimal");

                entity.Property(e => e.Alternate)
                    .HasColumnName("alternate")
                    .HasMaxLength(255);

                entity.Property(e => e.Applications)
                    .HasColumnName("applications")
                    .HasColumnType("varchar(3000)");

                entity.Property(e => e.AutoPickRf)
                    .HasColumnName("AutoPickRF")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AverageCostCdn)
                    .HasColumnName("average_cost_cdn")
                    .HasColumnType("money");

                entity.Property(e => e.AverageCostUsd)
                    .HasColumnName("average_cost_usd")
                    .HasColumnType("money");

                entity.Property(e => e.AveragePicksPerDay)
                    .HasColumnName("average_picks_per_day")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BoomiProcessDate)
                    .HasColumnName("boomi_process_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BuyingUnitId)
                    .HasColumnName("buying_unit_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CaseQuantity)
                    .HasColumnName("case_quantity")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.CubeDepth).HasColumnName("cube_depth");

                entity.Property(e => e.CubeHeight).HasColumnName("cube_height");

                entity.Property(e => e.CubeWidth).HasColumnName("cube_width");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IncludeInRanking)
                    .HasColumnName("include_in_ranking")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsCore).HasDefaultValueSql("0");

                entity.Property(e => e.IsRemanufacturedItem).HasDefaultValueSql("0");

                entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");

                entity.Property(e => e.ItemCategorySalesRanking)
                    .HasColumnName("item_category_sales_ranking")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemPopularityCodeId)
                    .HasColumnName("item_popularity_code_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemRanking)
                    .HasColumnName("item_ranking")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ItemRankingBasis)
                    .HasColumnName("item_ranking_basis")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemStatusId).HasColumnName("item_status_id");

                entity.Property(e => e.KeepPackageTogether)
                    .HasColumnName("keep_package_together")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("last_updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.LeadTimeDays)
                    .HasColumnName("lead_time_days")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LockRanking)
                    .HasColumnName("lock_ranking")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxItemStack).HasColumnName("max_item_stack");

                entity.Property(e => e.MaxOrder)
                    .HasColumnName("max_order")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxSuperceed)
                    .HasColumnName("max_superceed")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinOrder)
                    .HasColumnName("min_order")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MovementSpeed1)
                    .HasColumnName("movement_speed_1")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MovementSpeed2)
                    .HasColumnName("movement_speed_2")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.NetsuiteItemExternalId).HasColumnName("netsuite_item_external_id");

                entity.Property(e => e.OnSale).HasDefaultValueSql("0");

                entity.Property(e => e.OriginCountry)
                    .HasColumnName("origin_country")
                    .HasMaxLength(255);

                entity.Property(e => e.OverrideSkuInBin)
                    .HasColumnName("overrideSkuInBin")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PackageParts).HasColumnType("varchar(max)");

                entity.Property(e => e.PalletQuantity).HasColumnName("pallet_quantity");

                entity.Property(e => e.PoPalletQuantity).HasColumnName("po_pallet_quantity");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reorder)
                    .HasColumnName("reorder")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredPickingBins)
                    .HasColumnName("required_picking_bins")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RetailReserveQuantity).HasDefaultValueSql("0");

                entity.Property(e => e.SaleEndDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SaleStartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StructureCode)
                    .HasColumnName("structure_code")
                    .HasMaxLength(255);

                entity.Property(e => e.SuperceedList)
                    .HasColumnName("superceed_list")
                    .HasMaxLength(255);

                entity.Property(e => e.SuperceededByItemId).HasColumnName("superceeded_by_item_id");

                entity.Property(e => e.Upc)
                    .HasColumnName("upc")
                    .HasMaxLength(255);

                entity.Property(e => e.Upc2)
                    .HasColumnName("upc2")
                    .HasMaxLength(255);

                entity.Property(e => e.Upc3)
                    .HasColumnName("upc3")
                    .HasMaxLength(255);

                entity.Property(e => e.Upc4)
                    .HasColumnName("upc4")
                    .HasMaxLength(255);

                entity.Property(e => e.Upc5)
                    .HasColumnName("upc5")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UstariffCode)
                    .HasColumnName("USTariffCode")
                    .HasColumnType("varchar(16)");

                entity.Property(e => e.VaneCount)
                    .HasColumnName("vane_count")
                    .HasMaxLength(20);

                entity.Property(e => e.VaneWidthMm)
                    .HasColumnName("vane_width_mm")
                    .HasColumnType("decimal");

                entity.Property(e => e.Weight).HasColumnName("weight");
            });

            modelBuilder.Entity<ItemAmazonlisting>(entity =>
            {
                entity.HasKey(e => e.Sku)
                    .HasName("PK_item_amazonlisting");

                entity.ToTable("item_amazonlisting");

                entity.Property(e => e.Sku)
                    .HasColumnName("sku")
                    .HasMaxLength(50);

                entity.Property(e => e.Asin)
                    .HasColumnName("asin")
                    .HasMaxLength(50);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<ItemCategory>(entity =>
            {
                entity.ToTable("item_category");

                entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");

                entity.Property(e => e.Antidumping)
                    .HasColumnName("antidumping")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BinPercentageRequiredForReachTruckReplen)
                    .HasColumnName("bin_percentage_required_for_reach_truck_replen")
                    .HasColumnType("decimal");

                entity.Property(e => e.CategoryGroupStrings)
                    .HasColumnName("category_group_strings")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CustomsDocument)
                    .HasColumnName("customsDocument")
                    .HasMaxLength(100);

                entity.Property(e => e.DaysInventoryTolerance)
                    .HasColumnName("days_inventory_tolerance")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.DefaultVendorId)
                    .HasColumnName("default_vendor_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DefectAllowance)
                    .HasColumnName("defect_allowance")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.DimmensionalVariance)
                    .HasColumnName("dimmensionalVariance")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Discontinued)
                    .HasColumnName("discontinued")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DutyPercentage)
                    .HasColumnName("duty_percentage")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EquivalentPricingItemCategoryId)
                    .HasColumnName("equivalent_pricing_item_category_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Exforecast)
                    .HasColumnName("exforecast")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExportPercentage)
                    .HasColumnName("Export_percentage")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Fullpalletreplen)
                    .HasColumnName("fullpalletreplen")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HasPalletPricing)
                    .HasColumnName("has_pallet_pricing")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Heavy)
                    .HasColumnName("heavy")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IncludeAllUnits).HasColumnName("include_all_units");

                entity.Property(e => e.IsSoldOnline).HasColumnName("isSoldOnline");

                entity.Property(e => e.LabelMfg).HasColumnName("label_mfg");

                entity.Property(e => e.LabelMfgId).HasColumnName("label_mfg_id");

                entity.Property(e => e.LabelType).HasColumnName("label_type");

                entity.Property(e => e.LabelTypeId).HasColumnName("label_type_id");

                entity.Property(e => e.Labeltemplate)
                    .IsRequired()
                    .HasColumnName("labeltemplate")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ManufacturerId).HasColumnName("manufacturerId");

                entity.Property(e => e.MaxDaysInventory).HasColumnName("max_days_inventory");

                entity.Property(e => e.MaximumSkuPerBin)
                    .HasColumnName("maximum_sku_per_bin")
                    .HasDefaultValueSql("4");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.NetsuiteItemCategoryExternalId).HasColumnName("netsuite_item_category_external_id");

                entity.Property(e => e.PrintOrder)
                    .HasColumnName("print_order")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReplenIsActive)
                    .HasColumnName("replen_is_active")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RestockingThreshold).HasColumnName("restocking_threshold");

                entity.Property(e => e.RetailOrderBy)
                    .HasColumnName("retail_order_by")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SalesGroupId)
                    .HasColumnName("sales_group_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SellToCountryId)
                    .HasColumnName("sell_to_country_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ShowVendor)
                    .HasColumnName("show_vendor")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StackOrder).HasColumnName("stack_order");

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Targetlandedratio)
                    .HasColumnName("targetlandedratio")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UsTarrifCode)
                    .HasColumnName("us_tarrif_code")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ItemCategoryXAgedInventoryDiscountPeriod>(entity =>
            {
                entity.ToTable("item_category_x_aged_inventory_discount_period");

                entity.Property(e => e.ItemCategoryXAgedInventoryDiscountPeriodId).HasColumnName("item_category_x_aged_inventory_discount_period_id");

                entity.Property(e => e.AgedInventoryDiscountPeriodId).HasColumnName("aged_inventory_discount_period_id");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromDate)
                    .HasColumnName("from_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");

                entity.HasOne(d => d.AgedInventoryDiscountPeriod)
                    .WithMany(p => p.ItemCategoryXAgedInventoryDiscountPeriod)
                    .HasForeignKey(d => d.AgedInventoryDiscountPeriodId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_item_category_x_aged_inventory_discount_periode__aged_inventory_discount_period");

                entity.HasOne(d => d.ItemCategory)
                    .WithMany(p => p.ItemCategoryXAgedInventoryDiscountPeriod)
                    .HasForeignKey(d => d.ItemCategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_item_category_x_aged_inventory_discount_period__item_category");
            });

            modelBuilder.Entity<ItemCategoryXApprovedVendor>(entity =>
            {
                entity.ToTable("item_category_x_approved_vendor");

                entity.Property(e => e.ItemCategoryXApprovedVendorId).HasColumnName("item_category_x_approved_vendor_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemCategoryId)
                    .HasColumnName("item_category_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VendorId)
                    .HasColumnName("vendor_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VendorPercentage)
                    .HasColumnName("vendor_percentage")
                    .HasDefaultValueSql("100");
            });

            modelBuilder.Entity<ItemCategoryXBinPhysicalType>(entity =>
            {
                entity.ToTable("item_category_x_bin_physical_type");

                entity.Property(e => e.ItemCategoryXBinPhysicalTypeId).HasColumnName("item_category_x_bin_physical_type_id");

                entity.Property(e => e.BinPhysicalTypeId).HasColumnName("bin_physical_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");
            });

            modelBuilder.Entity<ItemCategoryXmanufacturer>(entity =>
            {
                entity.HasKey(e => new { e.ItemCategoryId, e.ManufacturerName })
                    .HasName("PK_itemCategoryXManufacturer");

                entity.ToTable("itemCategoryXManufacturer");

                entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");

                entity.Property(e => e.ManufacturerName)
                    .HasColumnName("manufacturerName")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<ItemCondition>(entity =>
            {
                entity.ToTable("item_condition");

                entity.Property(e => e.ItemConditionId).HasColumnName("item_condition_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemFaceType>(entity =>
            {
                entity.ToTable("item_face_type");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_item_face_typ_name")
                    .IsUnique();

                entity.Property(e => e.ItemFaceTypeId).HasColumnName("item_face_type_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ItemKit>(entity =>
            {
                entity.HasKey(e => new { e.KitItemId, e.AtomicItemId })
                    .HasName("PK_KIT");

                entity.ToTable("item_kit");

                entity.Property(e => e.KitItemId).HasColumnName("kit_item_id");

                entity.Property(e => e.AtomicItemId).HasColumnName("atomic_item_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("last_updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.AtomicItem)
                    .WithMany(p => p.ItemKitAtomicItem)
                    .HasForeignKey(d => d.AtomicItemId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ATOMIC_ITEM_ID__ITEM");

                entity.HasOne(d => d.KitItem)
                    .WithMany(p => p.ItemKitKitItem)
                    .HasForeignKey(d => d.KitItemId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_KIT_ITEM_ID__ITEM");
            });

            modelBuilder.Entity<ItemPalletQuantity>(entity =>
            {
                entity.ToTable("item_pallet_quantity");

                entity.Property(e => e.ItemPalletQuantityId).HasColumnName("item_pallet_quantity_id");

                entity.Property(e => e.ItemDefault)
                    .HasColumnName("item_default")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.PalletQuantity).HasColumnName("pallet_quantity");
            });

            modelBuilder.Entity<ItemPopularityCodes>(entity =>
            {
                entity.ToTable("item_popularity_codes");

                entity.Property(e => e.ItemPopularityCodesId).HasColumnName("item_popularity_codes_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.PercentileEnd).HasColumnName("percentile_end");

                entity.Property(e => e.PercentileStart).HasColumnName("percentile_start");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemStatus>(entity =>
            {
                entity.ToTable("item_status");

                entity.Property(e => e.ItemStatusId).HasColumnName("item_status_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemTrending>(entity =>
            {
                entity.ToTable("item_trending");

                entity.HasIndex(e => new { e.TrendMonth, e.TrendYear })
                    .HasName("idx_item_trending_02_03");

                entity.Property(e => e.ItemTrendingId).HasColumnName("item_trending_id");

                entity.Property(e => e.TrendMonth).HasColumnName("trend_month");

                entity.Property(e => e.TrendMultiplier)
                    .HasColumnName("trend_multiplier")
                    .HasColumnType("decimal");

                entity.Property(e => e.TrendYear).HasColumnName("trend_year");
            });

            modelBuilder.Entity<ItemXAsn>(entity =>
            {
                entity.ToTable("item_x_asn");

                entity.Property(e => e.ItemXAsnId).HasColumnName("item_x_asn_id");

                entity.Property(e => e.AsnId).HasColumnName("asn_id");

                entity.Property(e => e.CaseCubeDimensionId).HasColumnName("case_cube_dimension_id");

                entity.Property(e => e.CaseFaceCompositionId).HasColumnName("case_face_composition_id");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromDate)
                    .HasColumnName("from_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromUserId).HasColumnName("from_user_id");

                entity.Property(e => e.ItemCubeDimensionId).HasColumnName("item_cube_dimension_id");

                entity.Property(e => e.ItemFaceCompositionId).HasColumnName("item_face_composition_id");

                entity.Property(e => e.ItemFaceTypeId).HasColumnName("item_face_type_id");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemQuantityInCase).HasColumnName("item_quantity_in_case");

                entity.Property(e => e.ItemWeightKg).HasColumnName("item_weight_kg");

                entity.HasOne(d => d.CaseCubeDimension)
                    .WithMany(p => p.ItemXAsnCaseCubeDimension)
                    .HasForeignKey(d => d.CaseCubeDimensionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_item_x_asn__case_cube_dimension");

                entity.HasOne(d => d.CaseFaceComposition)
                    .WithMany(p => p.ItemXAsnCaseFaceComposition)
                    .HasForeignKey(d => d.CaseFaceCompositionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_item_x_asn__case_face_composition");

                entity.HasOne(d => d.ItemCubeDimension)
                    .WithMany(p => p.ItemXAsnItemCubeDimension)
                    .HasForeignKey(d => d.ItemCubeDimensionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_item_x_asn__item_cube_dimension");

                entity.HasOne(d => d.ItemFaceComposition)
                    .WithMany(p => p.ItemXAsnItemFaceComposition)
                    .HasForeignKey(d => d.ItemFaceCompositionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_item_x_asn__item_face_composition");

                entity.HasOne(d => d.ItemFaceType)
                    .WithMany(p => p.ItemXAsn)
                    .HasForeignKey(d => d.ItemFaceTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_item_x_asn__item_face_type");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemXAsn)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_item_x_asn__item");
            });

            modelBuilder.Entity<LabelType>(entity =>
            {
                entity.ToTable("label_type");

                entity.Property(e => e.LabelTypeId).HasColumnName("label_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.Expired).HasColumnName("expired");

                entity.Property(e => e.ForceLabelPrint)
                    .HasColumnName("force_label_print")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelDefaultQty).HasColumnName("label_default_qty");

                entity.Property(e => e.LabelDisplayHeight)
                    .HasColumnName("label_display_height")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelDisplayWidth)
                    .HasColumnName("label_display_width")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelSize)
                    .HasColumnName("label_size")
                    .HasMaxLength(255);

                entity.Property(e => e.LabelTypeName)
                    .HasColumnName("label_type_name")
                    .HasMaxLength(255);

                entity.Property(e => e.LabelsUp).HasColumnName("labels_up");
            });

            modelBuilder.Entity<LabelTypeXItemCategory>(entity =>
            {
                entity.ToTable("label_type_x_item_category");

                entity.Property(e => e.LabelTypeXItemCategoryId).HasColumnName("label_type_x_item_category_id");

                entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");

                entity.Property(e => e.LabelTypeId).HasColumnName("label_type_id");
            });

            modelBuilder.Entity<LocationType>(entity =>
            {
                entity.ToTable("location_type");

                entity.Property(e => e.LocationTypeId).HasColumnName("location_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<LogError>(entity =>
            {
                entity.Property(e => e.LogErrorId)
                    .HasColumnName("LogError_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.LogErrorSrc).HasMaxLength(100);
            });

            modelBuilder.Entity<LtlCutoffType>(entity =>
            {
                entity.ToTable("LTL_cutoff_type");

                entity.Property(e => e.LtlCutoffTypeId).HasColumnName("LTL_cutoff_type_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.ToTable("manufacturer");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_manufacturer_03");

                entity.Property(e => e.ManufacturerId).HasColumnName("manufacturer_id");

                entity.Property(e => e.Abbreviation)
                    .HasColumnName("abbreviation")
                    .HasMaxLength(255);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UseBarcode)
                    .HasColumnName("use_barcode")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ManufacturerCross>(entity =>
            {
                entity.ToTable("manufacturer_cross");

                entity.Property(e => e.ManufacturerCrossId).HasColumnName("manufacturer_cross_id");

                entity.Property(e => e.Abs)
                    .HasColumnName("ABS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Acdelco)
                    .HasColumnName("ACDELCO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Acf)
                    .HasColumnName("ACF")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Adi)
                    .HasColumnName("ADI")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Adl)
                    .HasColumnName("ADL")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Adt)
                    .HasColumnName("ADT")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Agnaupc)
                    .HasColumnName("AGNAUPC")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AiKey)
                    .HasColumnName("AI_KEY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AiUpc)
                    .HasColumnName("AI_UPC")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Aimco)
                    .HasColumnName("AIMCO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Airtex)
                    .HasColumnName("AIRTEX")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Alladina)
                    .HasColumnName("ALLADINA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Allsafe)
                    .HasColumnName("ALLSAFE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Amex)
                    .HasColumnName("AMEX")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Ammex)
                    .HasColumnName("AMMEX")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Anco)
                    .HasColumnName("ANCO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Ape)
                    .HasColumnName("APE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Arc)
                    .HasColumnName("ARC")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Ari)
                    .HasColumnName("ARI")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Asc)
                    .HasColumnName("ASC")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Atl)
                    .HasColumnName("ATL")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Atlas)
                    .HasColumnName("ATLAS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Atp)
                    .HasColumnName("ATP")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Auto)
                    .HasColumnName("AUTO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Autounlimited)
                    .HasColumnName("AUTOUNLIMITED")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Awceramic)
                    .HasColumnName("AWCERAMIC")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Balkamp)
                    .HasColumnName("BALKAMP")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Balkampdsh)
                    .HasColumnName("BALKAMPDSH")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Barcode)
                    .HasColumnName("barcode")
                    .HasColumnType("varchar(12)");

                entity.Property(e => e.Bbp)
                    .HasColumnName("BBP")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Bca)
                    .HasColumnName("BCA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Beck)
                    .HasColumnName("BECK")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Bendix)
                    .HasColumnName("BENDIX")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.BlueStreak)
                    .HasColumnName("BLUE_STREAK")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Bmp)
                    .HasColumnName("BMP")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Bosch)
                    .HasColumnName("BOSCH")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Brembo)
                    .HasColumnName("BREMBO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Brkpads)
                    .HasColumnName("BRKPADS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Brkshoes)
                    .HasColumnName("BRKSHOES")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Brockauto)
                    .HasColumnName("BROCKAUTO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Brook)
                    .HasColumnName("BROOK")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Bsp)
                    .HasColumnName("BSP")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Btk)
                    .HasColumnName("BTK")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.BwdAutomotive)
                    .HasColumnName("BWD_Automotive")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CalLidz)
                    .HasColumnName("Cal_Lidz")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Cardone)
                    .HasColumnName("CARDONE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Carpart)
                    .HasColumnName("CARPART")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Carquest)
                    .HasColumnName("CARQUEST")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Cbs)
                    .HasColumnName("CBS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Cct)
                    .HasColumnName("CCT")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Centric)
                    .HasColumnName("CENTRIC")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ChampAuto)
                    .HasColumnName("CHAMP_AUTO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ChampLube)
                    .HasColumnName("CHAMP_LUBE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ChampSrvc)
                    .HasColumnName("CHAMP_SRVC")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Chasselect)
                    .HasColumnName("CHASSELECT")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Climat)
                    .HasColumnName("CLIMAT")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Collins)
                    .HasColumnName("COLLINS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ConiSeal)
                    .HasColumnName("CONI_SEAL")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Crown)
                    .HasColumnName("CROWN")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Crs)
                    .HasColumnName("CRS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Csf)
                    .HasColumnName("CSF")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Cuc)
                    .HasColumnName("CUC")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CvUnlimited)
                    .HasColumnName("CV_UNLIMITED")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Dayco)
                    .HasColumnName("DAYCO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Delcode)
                    .HasColumnName("DELCODE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Delcodi)
                    .HasColumnName("DELCODI")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Delcoe)
                    .HasColumnName("DELCOE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Description1)
                    .HasColumnName("DESCRIPTION1")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Description2)
                    .HasColumnName("DESCRIPTION2")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Description3)
                    .HasColumnName("DESCRIPTION3")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Dns)
                    .HasColumnName("DNS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Dorman)
                    .HasColumnName("DORMAN")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Dpi)
                    .HasColumnName("DPI")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Driveplus)
                    .HasColumnName("DRIVEPLUS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Dss)
                    .HasColumnName("DSS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Dura)
                    .HasColumnName("DURA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Eclipse)
                    .HasColumnName("ECLIPSE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Eis)
                    .HasColumnName("EIS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Euro)
                    .HasColumnName("EURO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Exedy).HasColumnType("varchar(20)");

                entity.Property(e => e.FaKey)
                    .HasColumnName("FA_KEY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FelPro)
                    .HasColumnName("FEL_PRO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Fenco)
                    .HasColumnName("FENCO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Fpd)
                    .HasColumnName("FPD")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Fram)
                    .HasColumnName("FRAM")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Gabriel)
                    .HasColumnName("GABRIEL")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Gates)
                    .HasColumnName("GATES")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Gbm)
                    .HasColumnName("GBM")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Gmb)
                    .HasColumnName("GMB")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Godan)
                    .HasColumnName("GODAN")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Goodyear)
                    .HasColumnName("GOODYEAR")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Group).HasColumnName("group");

                entity.Property(e => e.Gsp)
                    .HasColumnName("GSP")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.GspNa)
                    .HasColumnName("GSP_NA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Hastings)
                    .HasColumnName("HASTINGS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Hollan)
                    .HasColumnName("HOLLAN")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Iapexpert)
                    .HasColumnName("IAPEXPERT")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Ilink)
                    .HasColumnName("ILINK")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Industries)
                    .HasColumnName("INDUSTRIES")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Ipi)
                    .HasColumnName("IPI")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Item)
                    .HasColumnName("item")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Jci)
                    .HasColumnName("JCI")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Kap)
                    .HasColumnName("KAP")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Kapaimco)
                    .HasColumnName("KAPAIMCO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Kapax)
                    .HasColumnName("KAPAX")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Kaptemp)
                    .HasColumnName("KAPTEMP")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Kapupc)
                    .HasColumnName("KAPUPC")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Koolvue)
                    .HasColumnName("KOOLVUE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Kralinator)
                    .HasColumnName("KRALINATOR")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Kyb)
                    .HasColumnName("KYB")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Leacree)
                    .HasColumnName("LEACREE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Lester)
                    .HasColumnName("LESTER")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Lizhong)
                    .HasColumnName("LIZHONG")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ManUpc)
                    .HasColumnName("MAN_UPC")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Mcquay)
                    .HasColumnName("MCQUAY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Mdpads)
                    .HasColumnName("MDPADS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Mev)
                    .HasColumnName("MEV")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Mgi)
                    .HasColumnName("MGI")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Midas)
                    .HasColumnName("MIDAS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Mighty)
                    .HasColumnName("MIGHTY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Modine)
                    .HasColumnName("MODINE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Monroe)
                    .HasColumnName("MONROE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Moog)
                    .HasColumnName("MOOG")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Motorcraft)
                    .HasColumnName("MOTORCRAFT")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MotownBendix)
                    .HasColumnName("MOTOWN_BENDIX")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MotownPart)
                    .HasColumnName("MOTOWN_PART")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MotownWagner)
                    .HasColumnName("MOTOWN_WAGNER")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Mtcad)
                    .HasColumnName("MTCAD")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Napa)
                    .HasColumnName("NAPA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Nat)
                    .HasColumnName("NAT")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Newcardone)
                    .HasColumnName("NEWCARDONE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Ng)
                    .HasColumnName("NG")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Ntk)
                    .HasColumnName("NTK")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Oem)
                    .HasColumnName("OEM")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Partslink)
                    .HasColumnName("PARTSLINK")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Patyoung)
                    .HasColumnName("PATYOUNG")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Pennzoil)
                    .HasColumnName("PENNZOIL")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Philips).HasColumnType("varchar(20)");

                entity.Property(e => e.Plumautoparts)
                    .HasColumnName("PLUMAUTOPARTS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Polyway)
                    .HasColumnName("POLYWAY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Powerline)
                    .HasColumnName("POWERLINE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Precision)
                    .HasColumnName("PRECISION")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Pri)
                    .HasColumnName("PRI")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Prtsmaster)
                    .HasColumnName("PRTSMASTER")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Ptc)
                    .HasColumnName("PTC")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Pucheng)
                    .HasColumnName("PUCHENG")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Purolator)
                    .HasColumnName("PUROLATOR")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Qkerstate)
                    .HasColumnName("QKERSTATE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Qualit)
                    .HasColumnName("QUALIT")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Rainx)
                    .HasColumnName("RAINX")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Ray)
                    .HasColumnName("RAY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RayR)
                    .HasColumnName("RAY_R")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Raymold)
                    .HasColumnName("RAYMOLD")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Redatech)
                    .HasColumnName("REDATECH")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Redstaltrw)
                    .HasColumnName("REDSTALTRW")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Reliab)
                    .HasColumnName("RELIAB")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Rockford)
                    .HasColumnName("ROCKFORD")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Rpt)
                    .HasColumnName("RPT")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Safeline)
                    .HasColumnName("SAFELINE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Satisfied)
                    .HasColumnName("SATISFIED")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Sensen).HasColumnType("varchar(20)");

                entity.Property(e => e.Seymourauto)
                    .HasColumnName("SEYMOURAUTO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Skf)
                    .HasColumnName("SKF")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Spe)
                    .HasColumnName("SPE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Specd)
                    .HasColumnName("SPECD")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Spi)
                    .HasColumnName("SPI")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Spicer)
                    .HasColumnName("SPICER")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Spyder)
                    .HasColumnName("SPYDER")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Strutmaster)
                    .HasColumnName("STRUTMASTER")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Summer)
                    .HasColumnName("SUMMER")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Suncore)
                    .HasColumnName("SUNCORE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Surtrack)
                    .HasColumnName("SURTRACK")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Syl)
                    .HasColumnName("SYL")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Timken)
                    .HasColumnName("TIMKEN")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Tinker)
                    .HasColumnName("TINKER")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Tires)
                    .HasColumnName("TIRES")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Tomhovland)
                    .HasColumnName("TOMHOVLAND")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Tra)
                    .HasColumnName("TRA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.TruStar)
                    .HasColumnName("TRU_STAR")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Trw)
                    .HasColumnName("TRW")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Tyc)
                    .HasColumnName("TYC")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Ubp)
                    .HasColumnName("UBP")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Ucdpads)
                    .HasColumnName("UCDPADS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Usa)
                    .HasColumnName("USA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Val)
                    .HasColumnName("VAL")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Valeo)
                    .HasColumnName("VALEO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Vipar)
                    .HasColumnName("VIPAR")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Vision)
                    .HasColumnName("VISION")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Wag)
                    .HasColumnName("WAG")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Wagbd)
                    .HasColumnName("WAGBD")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Wai)
                    .HasColumnName("WAI")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Walker)
                    .HasColumnName("WALKER")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Wells)
                    .HasColumnName("WELLS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Wheels)
                    .HasColumnName("WHEELS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Wiper)
                    .HasColumnName("WIPER")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Wiperelement)
                    .HasColumnName("WIPERELEMENT")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Wisota)
                    .HasColumnName("WISOTA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Wix)
                    .HasColumnName("WIX")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Wolverine)
                    .HasColumnName("WOLVERINE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Worldbrakecorp)
                    .HasColumnName("WORLDBRAKECORP")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<ManufacturerCrossRelational>(entity =>
            {
                entity.ToTable("manufacturer_cross_relational");

                entity.HasIndex(e => new { e.ItemId, e.FkManufacturerId })
                    .HasName("itemFKManIndex");

                entity.Property(e => e.ManufacturerCrossRelationalId).HasColumnName("manufacturer_cross_relational_id");

                entity.Property(e => e.FkManufacturerId)
                    .HasColumnName("fkManufacturerID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsMainCross).HasColumnName("isMainCross");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemName)
                    .HasColumnName("item_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ManufacturerId)
                    .HasColumnName("manufacturer_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ManufacturerItemId)
                    .HasColumnName("manufacturer_item_id")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ManufacturerPcaousCategory>(entity =>
            {
                entity.HasKey(e => new { e.ManufacturerId, e.CategoryId })
                    .HasName("PK_manufacturer_PCAOUS_category");

                entity.ToTable("manufacturer_PCAOUS_category");

                entity.Property(e => e.ManufacturerId).HasColumnName("manufacturer_id");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.EBayXreferenceOrder)
                    .HasColumnName("eBayXReferenceOrder")
                    .HasDefaultValueSql("100");
            });

            modelBuilder.Entity<Membership>(entity =>
            {
                entity.ToTable("membership");

                entity.Property(e => e.MembershipId).HasColumnName("membership_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("menu");

                entity.HasIndex(e => e.MenuName)
                    .HasName("idx_menu_03");

                entity.Property(e => e.MenuId).HasColumnName("menu_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.GroupName)
                    .HasColumnName("group_name")
                    .HasMaxLength(255);

                entity.Property(e => e.HelpDescription)
                    .HasColumnName("help_description")
                    .HasMaxLength(255);

                entity.Property(e => e.MenuGroupId)
                    .HasColumnName("menu_group_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MenuName)
                    .HasColumnName("menu_name")
                    .HasMaxLength(255);

                entity.Property(e => e.PermissionId)
                    .HasColumnName("permission_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Report)
                    .HasColumnName("report")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MenuGroup>(entity =>
            {
                entity.ToTable("menu_group");

                entity.Property(e => e.MenuGroupId).HasColumnName("menu_group_id");

                entity.Property(e => e.MenuGroupName)
                    .HasColumnName("menu_group_name")
                    .HasMaxLength(255);

                entity.Property(e => e.MenuGroupOrder)
                    .HasColumnName("menu_group_order")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MenuRf>(entity =>
            {
                entity.ToTable("menu_rf");

                entity.Property(e => e.MenuRfId).HasColumnName("menu_rf_id");

                entity.Property(e => e.FunctionName)
                    .HasColumnName("function_name")
                    .HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Menuflag).HasColumnName("menuflag");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Order).HasColumnName("order");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");
            });

            modelBuilder.Entity<MenuRfNew>(entity =>
            {
                entity.HasKey(e => e.MenuRfId)
                    .HasName("pk_menu_rf_new");

                entity.ToTable("menu_rf_New");

                entity.Property(e => e.MenuRfId).HasColumnName("menu_rf_id");

                entity.Property(e => e.FunctionName)
                    .HasColumnName("function_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Menuflag).HasColumnName("menuflag");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PermissionId)
                    .HasColumnName("permission_id")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MenuRfOld>(entity =>
            {
                entity.HasKey(e => e.MenuRfId)
                    .HasName("pk_menu_rf_old");

                entity.ToTable("menu_rf_old");

                entity.Property(e => e.MenuRfId).HasColumnName("menu_rf_id");

                entity.Property(e => e.FunctionName)
                    .HasColumnName("function_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Menuflag).HasColumnName("menuflag");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Order).HasColumnName("order");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");
            });

            modelBuilder.Entity<MenuRfXWarehouse>(entity =>
            {
                entity.ToTable("menu_rf_x_warehouse");

                entity.Property(e => e.MenuRfXWarehouseId).HasColumnName("menu_rf_x_warehouse_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MenuRfId)
                    .HasColumnName("menu_rf_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WarehouseId)
                    .HasColumnName("warehouse_id")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PackagingType>(entity =>
            {
                entity.ToTable("packaging_type");

                entity.Property(e => e.PackagingTypeId).HasColumnName("packaging_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.PriceImportName)
                    .HasColumnName("price_import_name")
                    .HasMaxLength(100);

                entity.Property(e => e.PriceListName)
                    .HasColumnName("price_list_name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasColumnName("update_user");
            });

            modelBuilder.Entity<PartSpecifics>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK_partSpecifics");

                entity.ToTable("partSpecifics");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PartSpecifics1)
                    .IsRequired()
                    .HasColumnName("partSpecifics");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("permission");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_permission_02");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Group1)
                    .HasColumnName("group_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Group2)
                    .HasColumnName("group_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Group3)
                    .HasColumnName("group_3")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PickingOrderStatus>(entity =>
            {
                entity.ToTable("picking_order_status");

                entity.Property(e => e.PickingOrderStatusId).HasColumnName("picking_order_status_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PickingReason>(entity =>
            {
                entity.ToTable("picking_reason");

                entity.Property(e => e.PickingReasonId)
                    .HasColumnName("picking_reason_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PickingType>(entity =>
            {
                entity.ToTable("picking_type");

                entity.Property(e => e.PickingTypeId).HasColumnName("pickingTypeID");

                entity.Property(e => e.AllowHeavy)
                    .HasColumnName("allow_heavy")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllowPalletPick)
                    .HasColumnName("allow_pallet_pick")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.AllowPick)
                    .HasColumnName("allow_pick")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.MaxItemsPerBin)
                    .HasColumnName("maxItemsPerBin")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PickingTypeDescription)
                    .HasColumnName("pickingTypeDescription")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PickingTypeName)
                    .HasColumnName("pickingTypeName")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<PoInvoiceStatus>(entity =>
            {
                entity.ToTable("po_invoice_status");

                entity.Property(e => e.PoInvoiceStatusId).HasColumnName("po_invoice_status_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PoInvoiceType>(entity =>
            {
                entity.ToTable("po_invoice_type");

                entity.Property(e => e.PoInvoiceTypeId).HasColumnName("po_invoice_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PoStatus>(entity =>
            {
                entity.ToTable("po_status");

                entity.Property(e => e.PoStatusId).HasColumnName("po_status_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PriceListOutputRowDefinition>(entity =>
            {
                entity.ToTable("price_list_output_row_definition");

                entity.Property(e => e.PriceListOutputRowDefinitionId).HasColumnName("price_list_output_row_definition_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IncludeAllItems).HasColumnName("include_all_items");

                entity.Property(e => e.IncludeApplication)
                    .HasColumnName("include_application")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemCategoryId)
                    .HasColumnName("item_category_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemCategoryIdList)
                    .HasColumnName("item_category_id_list")
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.PriceListOutputRowDefinition1).HasColumnName("PriceListOutputRowDefinition");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ProvinceState>(entity =>
            {
                entity.ToTable("province_state");

                entity.Property(e => e.ProvinceStateId).HasColumnName("province_state_id");

                entity.Property(e => e.CountryId)
                    .HasColumnName("country_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasMaxLength(50);

                entity.Property(e => e.PostalAbbreviation)
                    .HasColumnName("postal_abbreviation")
                    .HasMaxLength(6);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ProvinceState)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("fk_province_state_04");
            });

            modelBuilder.Entity<QueuingConfiguration>(entity =>
            {
                entity.ToTable("queuing_configuration");

                entity.Property(e => e.QueuingConfigurationId).HasColumnName("queuing_configuration_id");

                entity.Property(e => e.CrossAisleFactor).HasColumnName("cross_aisle_factor");

                entity.Property(e => e.HighLoosePickFactor).HasColumnName("high_loose_pick_factor");

                entity.Property(e => e.HighPickFactor).HasColumnName("high_pick_factor");

                entity.Property(e => e.LowLoosePickFactor).HasColumnName("low_loose_pick_factor");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.NewItemFactor).HasColumnName("new_item_factor");

                entity.Property(e => e.NewLocationFactor).HasColumnName("new_location_factor");

                entity.Property(e => e.NewPalletFactor).HasColumnName("new_pallet_factor");

                entity.Property(e => e.PalletPickFactor).HasColumnName("pallet_pick_factor");

                entity.Property(e => e.PalletPickForLooseFactor).HasColumnName("pallet_pick_for_loose_factor");

                entity.Property(e => e.ReserveBinFactor)
                    .HasColumnName("reserve_bin_factor")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.XyDistanceFactor).HasColumnName("xy_distance_factor");

                entity.Property(e => e.ZDistanceFactor).HasColumnName("z_distance_factor");
            });

            modelBuilder.Entity<ReplenishmentOrderDiscrepancyType>(entity =>
            {
                entity.ToTable("replenishment_order_discrepancy_type");

                entity.Property(e => e.ReplenishmentOrderDiscrepancyTypeId)
                    .HasColumnName("replenishment_order_discrepancy_type_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DiscrepancyDescription)
                    .HasColumnName("discrepancy_description")
                    .HasMaxLength(50);

                entity.Property(e => e.DiscrepancyName)
                    .HasColumnName("discrepancy_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ReplenishmentOrderType>(entity =>
            {
                entity.ToTable("replenishment_order_type");

                entity.Property(e => e.ReplenishmentOrderTypeId)
                    .HasColumnName("replenishment_order_type_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReplenishmentOrderTypeName)
                    .HasColumnName("replenishment_order_type_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ReplenishmentTransferTypeId).HasColumnName("replenishment_transfer_type_id");
            });

            modelBuilder.Entity<RgaResult>(entity =>
            {
                entity.ToTable("rga_result");

                entity.Property(e => e.RgaResultId).HasColumnName("rga_result_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsRetail).HasColumnName("is_retail");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ToStock).HasColumnName("to_stock");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<RgaStatus>(entity =>
            {
                entity.ToTable("rga_status");

                entity.Property(e => e.RgaStatusId).HasColumnName("rga_status_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<RoStatus>(entity =>
            {
                entity.ToTable("ro_status");

                entity.Property(e => e.RoStatusId).HasColumnName("ro_status_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SalesChannel>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SalesPartner>(entity =>
            {
                entity.ToTable("sales_partner");

                entity.Property(e => e.SalesPartnerId).HasColumnName("sales_partner_id");

                entity.Property(e => e.BusinessId)
                    .HasColumnName("business_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PartnerBusinessId)
                    .HasColumnName("partner_business_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<SalesPaymentMethod>(entity =>
            {
                entity.ToTable("sales_payment_method");

                entity.Property(e => e.SalesPaymentMethodId).HasColumnName("sales_payment_method_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SalesPaymentXSoInvoiceReferenceType>(entity =>
            {
                entity.ToTable("sales_payment_x_so_invoice_reference_type");

                entity.Property(e => e.SalesPaymentXSoInvoiceReferenceTypeId).HasColumnName("sales_payment_x_so_invoice_reference_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SalesQualification>(entity =>
            {
                entity.ToTable("sales_qualification");

                entity.Property(e => e.SalesQualificationId).HasColumnName("sales_qualification_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SalesRepresentative>(entity =>
            {
                entity.ToTable("sales_representative");

                entity.Property(e => e.SalesRepresentativeId).HasColumnName("sales_representative_id");

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasMaxLength(255);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DefaultCommission)
                    .HasColumnName("default_commission")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(255);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(255);

                entity.Property(e => e.ReportsToId)
                    .HasColumnName("reports_to_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SalesRepresentativeTypeId)
                    .HasColumnName("sales_representative_type_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<SalesRepresentativeType>(entity =>
            {
                entity.ToTable("sales_representative_type");

                entity.Property(e => e.SalesRepresentativeTypeId).HasColumnName("sales_representative_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SalesRepresentativeXAddress>(entity =>
            {
                entity.ToTable("sales_representative_x_address");

                entity.Property(e => e.SalesRepresentativeXAddressId).HasColumnName("sales_representative_x_address_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SalesRepresentativeId).HasColumnName("sales_representative_id");
            });

            modelBuilder.Entity<SellToCountry>(entity =>
            {
                entity.ToTable("sell_to_country");

                entity.Property(e => e.SellToCountryId).HasColumnName("sell_to_country_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ShippingCompany>(entity =>
            {
                entity.Property(e => e.ContactEmail).HasMaxLength(250);

                entity.Property(e => e.ContactName).HasMaxLength(250);

                entity.Property(e => e.ContactNumber).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.Details).HasMaxLength(2000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasColumnName("update_user");
            });

            modelBuilder.Entity<ShippingDeliveryDates>(entity =>
            {
                entity.Property(e => e.ShippingDeliveryDatesId).HasColumnName("ShippingDeliveryDates_id");

                entity.Property(e => e.DeliveredDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedDate).HasColumnType("datetime");

                entity.Property(e => e.ShippedDate).HasColumnType("datetime");

                entity.Property(e => e.ShipperName)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.TrackingNumber)
                    .IsRequired()
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<ShippingDocumentEditotals>(entity =>
            {
                entity.ToTable("ShippingDocumentEDITotals");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Editotal)
                    .HasColumnName("EDITotal")
                    .HasColumnType("money");

                entity.Property(e => e.ShippingDocumentId).HasColumnName("ShippingDocumentID");
            });

            modelBuilder.Entity<ShippingQuote>(entity =>
            {
                entity.ToTable("shipping_quote");

                entity.Property(e => e.ShippingQuoteId).HasColumnName("shipping_quote_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.Expiration)
                    .HasColumnName("expiration")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ftlcdn).HasColumnName("FTLCDN");

                entity.Property(e => e.Ftlus).HasColumnName("FTLUS");

                entity.Property(e => e.LtlCutoff).HasColumnName("LTL_cutoff");

                entity.Property(e => e.LtlCutoffTypeId).HasColumnName("LTL_cutoff_type_id");

                entity.Property(e => e.Ltlcdn).HasColumnName("LTLCDN");

                entity.Property(e => e.Ltlus).HasColumnName("LTLUS");

                entity.Property(e => e.MaxSkidWeight).HasColumnName("max_skid_weight");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingQuoteStructureId).HasColumnName("shipping_quote_structure_id");

                entity.Property(e => e.ShippingQuoteTypeId).HasColumnName("shipping_quote_type_id");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasColumnName("update_user");

                entity.Property(e => e.VendorId).HasColumnName("vendor_id");

                entity.HasOne(d => d.LtlCutoffType)
                    .WithMany(p => p.ShippingQuote)
                    .HasForeignKey(d => d.LtlCutoffTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_shipping_quote_15");

                entity.HasOne(d => d.ShippingQuoteStructure)
                    .WithMany(p => p.ShippingQuote)
                    .HasForeignKey(d => d.ShippingQuoteStructureId)
                    .HasConstraintName("fk_shipping_quote_16");

                entity.HasOne(d => d.ShippingQuoteType)
                    .WithMany(p => p.ShippingQuote)
                    .HasForeignKey(d => d.ShippingQuoteTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_shipping_quote_05");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.ShippingQuote)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_shipping_quote_02");
            });

            modelBuilder.Entity<ShippingQuoteEntity>(entity =>
            {
                entity.ToTable("shipping_quote_entity");

                entity.Property(e => e.ShippingQuoteEntityId).HasColumnName("shipping_quote_entity_id");

                entity.Property(e => e.ShippingQuoteEntityTypeId).HasColumnName("shipping_quote_entity_type_id");

                entity.Property(e => e.ShippingQuoteId).HasColumnName("shipping_quote_id");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.ShippingQuoteEntityType)
                    .WithMany(p => p.ShippingQuoteEntity)
                    .HasForeignKey(d => d.ShippingQuoteEntityTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_shipping_quote_entity_04");

                entity.HasOne(d => d.ShippingQuote)
                    .WithMany(p => p.ShippingQuoteEntity)
                    .HasForeignKey(d => d.ShippingQuoteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_shipping_quote_entity_03");
            });

            modelBuilder.Entity<ShippingQuoteEntityType>(entity =>
            {
                entity.ToTable("shipping_quote_entity_type");

                entity.Property(e => e.ShippingQuoteEntityTypeId).HasColumnName("shipping_quote_entity_type_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingQuoteEntityValueTypeId).HasColumnName("shipping_quote_entity_value_type_id");
            });

            modelBuilder.Entity<ShippingQuoteEntityValueType>(entity =>
            {
                entity.ToTable("shipping_quote_entity_value_type");

                entity.Property(e => e.ShippingQuoteEntityValueTypeId).HasColumnName("shipping_quote_entity_value_type_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ShippingQuoteLine>(entity =>
            {
                entity.ToTable("shipping_quote_line");

                entity.Property(e => e.ShippingQuoteLineId).HasColumnName("shipping_quote_line_id");

                entity.Property(e => e.ShippingQuoteId).HasColumnName("shipping_quote_id");

                entity.HasOne(d => d.ShippingQuote)
                    .WithMany(p => p.ShippingQuoteLine)
                    .HasForeignKey(d => d.ShippingQuoteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_shipping_quote_line_02");
            });

            modelBuilder.Entity<ShippingQuoteLineEntity>(entity =>
            {
                entity.ToTable("shipping_quote_line_entity");

                entity.HasIndex(e => new { e.ShippingQuoteLineId, e.ShippingQuoteEntityTypeId, e.OccurrenceValue })
                    .HasName("idx_shipping_quote_line_entity_02_03_04");

                entity.Property(e => e.ShippingQuoteLineEntityId).HasColumnName("shipping_quote_line_entity_id");

                entity.Property(e => e.LineEntityValue).HasColumnName("line_entity_value");

                entity.Property(e => e.OccurrenceValue).HasColumnName("occurrence_value");

                entity.Property(e => e.ShippingQuoteEntityTypeId).HasColumnName("shipping_quote_entity_type_id");

                entity.Property(e => e.ShippingQuoteLineId).HasColumnName("shipping_quote_line_id");
            });

            modelBuilder.Entity<ShippingQuoteLineXCity>(entity =>
            {
                entity.ToTable("shipping_quote_line_x_city");

                entity.Property(e => e.ShippingQuoteLineXCityId).HasColumnName("shipping_quote_line_x_city_id");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.ShippingQuoteLineId).HasColumnName("shipping_quote_line_id");
            });

            modelBuilder.Entity<ShippingQuoteLineXProvinceState>(entity =>
            {
                entity.ToTable("shipping_quote_line_x_province_state");

                entity.Property(e => e.ShippingQuoteLineXProvinceStateId).HasColumnName("shipping_quote_line_x_province_state_id");

                entity.Property(e => e.ProvinceStateId).HasColumnName("province_state_id");

                entity.Property(e => e.ShippingQuoteLineId).HasColumnName("shipping_quote_line_id");
            });

            modelBuilder.Entity<ShippingQuoteSchema>(entity =>
            {
                entity.ToTable("shipping_quote_schema");

                entity.Property(e => e.ShippingQuoteSchemaId).HasColumnName("shipping_quote_schema_id");

                entity.Property(e => e.ColumnIndex).HasColumnName("column_index");

                entity.Property(e => e.IsColumn).HasColumnName("is_column");

                entity.Property(e => e.OccurenceValues)
                    .HasColumnName("occurence_values")
                    .HasMaxLength(255);

                entity.Property(e => e.Occurrences).HasColumnName("occurrences");

                entity.Property(e => e.ShippingQuoteEntityTypeId).HasColumnName("shipping_quote_entity_type_id");

                entity.Property(e => e.ShippingQuoteStructureId).HasColumnName("shipping_quote_structure_id");

                entity.HasOne(d => d.ShippingQuoteEntityType)
                    .WithMany(p => p.ShippingQuoteSchema)
                    .HasForeignKey(d => d.ShippingQuoteEntityTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_shipping_quote_schema_07");

                entity.HasOne(d => d.ShippingQuoteStructure)
                    .WithMany(p => p.ShippingQuoteSchema)
                    .HasForeignKey(d => d.ShippingQuoteStructureId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_shipping_quote_schema_06");
            });

            modelBuilder.Entity<ShippingQuoteStructure>(entity =>
            {
                entity.ToTable("shipping_quote_structure");

                entity.Property(e => e.ShippingQuoteStructureId).HasColumnName("shipping_quote_structure_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingQuoteTypeId).HasColumnName("shipping_quote_type_id");

                entity.HasOne(d => d.ShippingQuoteType)
                    .WithMany(p => p.ShippingQuoteStructure)
                    .HasForeignKey(d => d.ShippingQuoteTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_shipping_quote_structure_03");
            });

            modelBuilder.Entity<ShippingQuoteType>(entity =>
            {
                entity.ToTable("shipping_quote_type");

                entity.Property(e => e.ShippingQuoteTypeId).HasColumnName("shipping_quote_type_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ShippingRate>(entity =>
            {
                entity.ToTable("shipping_rate");

                entity.Property(e => e.ShippingRateId).HasColumnName("shipping_rate_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxSkidCount)
                    .HasColumnName("max_skid_count")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinSkidCount)
                    .HasColumnName("min_skid_count")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingRateTotal)
                    .HasColumnName("shipping_rate_total")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasColumnName("update_user");

                entity.Property(e => e.VendorId)
                    .HasColumnName("vendor_id")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SoInvoiceStatus>(entity =>
            {
                entity.ToTable("so_invoice_status");

                entity.Property(e => e.SoInvoiceStatusId).HasColumnName("so_invoice_status_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SoStatus>(entity =>
            {
                entity.ToTable("so_status");

                entity.Property(e => e.SoStatusId).HasColumnName("so_status_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SystemValue>(entity =>
            {
                entity.ToTable("system_value");

                entity.Property(e => e.SystemValueId).HasColumnName("system_value_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupName)
                    .HasColumnName("group_name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("task");

                entity.HasIndex(e => new { e.TaskStatusId, e.AssignedTo })
                    .HasName("idx_tesk_06_10");

                entity.Property(e => e.TaskId).HasColumnName("task_id");

                entity.Property(e => e.AssignedTo)
                    .HasColumnName("assigned_to")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DueDate)
                    .HasColumnName("due_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PerformUser)
                    .HasColumnName("perform_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PerformedDate)
                    .HasColumnName("performed_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasColumnType("ntext");

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(1000);

                entity.Property(e => e.TaskPriorityId)
                    .HasColumnName("task_priority_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TaskStatusId)
                    .HasColumnName("task_status_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TaskTypeId)
                    .HasColumnName("task_type_id")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TaskPriority>(entity =>
            {
                entity.ToTable("task_priority");

                entity.Property(e => e.TaskPriorityId).HasColumnName("task_priority_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TaskStatus>(entity =>
            {
                entity.ToTable("task_status");

                entity.Property(e => e.TaskStatusId).HasColumnName("task_status_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TaskType>(entity =>
            {
                entity.ToTable("task_type");

                entity.Property(e => e.TaskTypeId).HasColumnName("task_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Tax>(entity =>
            {
                entity.ToTable("tax");

                entity.Property(e => e.TaxId).HasColumnName("tax_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TaxCode>(entity =>
            {
                entity.ToTable("tax_code");

                entity.Property(e => e.TaxCodeId).HasColumnName("tax_code_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TaxCodeIdOld)
                    .HasColumnName("tax_code_id_old")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TaxCodeXTax>(entity =>
            {
                entity.HasKey(e => new { e.TaxCodeId, e.TaxId })
                    .HasName("pk_tax_code_x_tax");

                entity.ToTable("tax_code_x_tax");

                entity.Property(e => e.TaxCodeId)
                    .HasColumnName("tax_code_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TaxId)
                    .HasColumnName("tax_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TaxCodeXTaxId)
                    .HasColumnName("tax_code_x_tax_id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Terms>(entity =>
            {
                entity.ToTable("terms");

                entity.Property(e => e.TermsId).HasColumnName("terms_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CrossoverDay)
                    .HasColumnName("crossover_day")
                    .HasMaxLength(255);

                entity.Property(e => e.DateDriven)
                    .HasColumnName("date_driven")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DayDue)
                    .HasColumnName("day_due")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.P1Days)
                    .HasColumnName("p1_days")
                    .HasMaxLength(50);

                entity.Property(e => e.P1PercentDue)
                    .HasColumnName("p1_percent_due")
                    .HasMaxLength(50);

                entity.Property(e => e.P2Days)
                    .HasColumnName("p2_days")
                    .HasMaxLength(50);

                entity.Property(e => e.P2PercentDue)
                    .HasColumnName("p2_percent_due")
                    .HasMaxLength(50);

                entity.Property(e => e.P3Days)
                    .HasColumnName("p3_days")
                    .HasMaxLength(50);

                entity.Property(e => e.P3PercentDue)
                    .HasColumnName("p3_percent_due")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TransferType>(entity =>
            {
                entity.ToTable("transfer_type");

                entity.Property(e => e.TransferTypeId).HasColumnName("transfer_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DefaultWarehouseId)
                    .HasColumnName("default_warehouse_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(255);

                entity.Property(e => e.IsDriver)
                    .HasColumnName("isDriver")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsGarysStore)
                    .HasColumnName("isGarysStore")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastLogin)
                    .HasColumnName("last_login")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.PickHeavy)
                    .HasColumnName("pick_heavy")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PickHigh)
                    .HasColumnName("pick_high")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PickPriority).HasColumnName("pick_priority");

                entity.Property(e => e.PickQuick)
                    .HasColumnName("pick_quick")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PickReserveOrder).HasColumnName("pick_reserve_order");

                entity.Property(e => e.TotalLogins)
                    .HasColumnName("total_logins")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<UserPriceListOutput>(entity =>
            {
                entity.ToTable("user_price_list_output");

                entity.HasIndex(e => new { e.SubmitType, e.JobStatus })
                    .HasName("idx_user_price_list_output_03_09");

                entity.Property(e => e.UserPriceListOutputId).HasColumnName("user_price_list_output_id");

                entity.Property(e => e.BusinessSizeId).HasColumnName("business_size_id");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ClientTypeId).HasColumnName("client_type_id");

                entity.Property(e => e.ConfirmDate)
                    .HasColumnName("confirm_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ConfirmUserId).HasColumnName("confirm_user_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerTypeId).HasColumnName("customer_type_id");

                entity.Property(e => e.EmailFilter)
                    .HasColumnName("email_filter")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmailText)
                    .HasColumnName("email_text")
                    .HasMaxLength(2000);

                entity.Property(e => e.ExcelFilename)
                    .HasColumnName("excel_filename")
                    .HasMaxLength(255);

                entity.Property(e => e.IncludeApplication)
                    .HasColumnName("include_application")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.JobStatus).HasColumnName("job_status");

                entity.Property(e => e.PdfFilename)
                    .HasColumnName("pdf_filename")
                    .HasMaxLength(255);

                entity.Property(e => e.PresetId).HasColumnName("preset_id");

                entity.Property(e => e.PriceListEffectiveDate)
                    .HasColumnName("price_list_effective_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PriceListId).HasColumnName("price_list_id");

                entity.Property(e => e.PriceListOutputName)
                    .HasColumnName("price_list_output_name")
                    .HasMaxLength(255);

                entity.Property(e => e.PriceListToSend).HasColumnName("price_list_to_send");

                entity.Property(e => e.SubmitType).HasColumnName("submit_type");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<UserPriceListOutputDetail>(entity =>
            {
                entity.ToTable("user_price_list_output_detail");

                entity.HasIndex(e => new { e.CustomerId, e.Sent })
                    .HasName("idx_user_price_list_output_detail_");

                entity.Property(e => e.UserPriceListOutputDetailId).HasColumnName("user_price_list_output_detail_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasColumnName("customer_name")
                    .HasMaxLength(255);

                entity.Property(e => e.FormChecked).HasColumnName("form_checked");

                entity.Property(e => e.HasEmail).HasColumnName("has_email");

                entity.Property(e => e.Sent).HasColumnName("sent");

                entity.Property(e => e.UserPriceListOutputId).HasColumnName("user_price_list_output_id");
            });

            modelBuilder.Entity<UspsorderParts>(entity =>
            {
                entity.HasKey(e => e.OrderPartId)
                    .HasName("PK_USPSOrderParts");

                entity.ToTable("USPSOrderParts");

                entity.Property(e => e.OrderPartId).HasColumnName("OrderPartID");

                entity.Property(e => e.ItemName)
                    .HasColumnName("item_name")
                    .HasMaxLength(100);

                entity.Property(e => e.OrderId).HasColumnName("orderID");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");

                entity.Property(e => e.Qty).HasColumnName("qty");
            });

            modelBuilder.Entity<Uspsorders>(entity =>
            {
                entity.ToTable("USPSOrders");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerAddress1)
                    .HasColumnName("customer_address1")
                    .HasMaxLength(120);

                entity.Property(e => e.CustomerAddress2)
                    .HasColumnName("customer_address2")
                    .HasMaxLength(120);

                entity.Property(e => e.CustomerCity)
                    .HasColumnName("customer_city")
                    .HasMaxLength(90);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(200);

                entity.Property(e => e.CustomerPhone)
                    .HasColumnName("customer_phone")
                    .HasMaxLength(15);

                entity.Property(e => e.CustomerState)
                    .HasColumnName("customer_state")
                    .HasMaxLength(15);

                entity.Property(e => e.CustomerZip)
                    .HasColumnName("customer_zip")
                    .HasMaxLength(10);

                entity.Property(e => e.SoId).HasColumnName("so_id");

                entity.Property(e => e.UspsManifestDate)
                    .HasColumnName("usps_manifest_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Uspscost)
                    .HasColumnName("USPSCost")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("vendor");

                entity.Property(e => e.VendorId).HasColumnName("vendor_id");

                entity.Property(e => e.Addcase)
                    .HasColumnName("ADDCase")
                    .HasMaxLength(150);

                entity.Property(e => e.CountryId)
                    .HasColumnName("country_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.Currency)
                    .HasColumnName("currency")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Duty).HasColumnType("money");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(255);

                entity.Property(e => e.IsBuyoutVendor).HasColumnName("isBuyoutVendor");

                entity.Property(e => e.ManufacturerName).HasMaxLength(150);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.NetsuiteVendorExternalId).HasColumnName("netsuite_vendor_external_id");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxCodeId)
                    .HasColumnName("tax_code_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VendorExportCode)
                    .HasColumnName("vendor_export_code")
                    .HasMaxLength(225);

                entity.Property(e => e.VendorTypeId).HasColumnName("vendor_type_id");
            });

            modelBuilder.Entity<VendorType>(entity =>
            {
                entity.ToTable("vendor_type");

                entity.Property(e => e.VendorTypeId).HasColumnName("vendor_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<VendorTypeXPoInvoiceType>(entity =>
            {
                entity.HasKey(e => new { e.PoInvoiceTypeId, e.VendorTypeId })
                    .HasName("pk_vendor_type_x_po_invoice_type");

                entity.ToTable("vendor_type_x_po_invoice_type");

                entity.Property(e => e.PoInvoiceTypeId)
                    .HasColumnName("po_invoice_type_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VendorTypeId)
                    .HasColumnName("vendor_type_id")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<VendorXAddress>(entity =>
            {
                entity.HasKey(e => new { e.VendorXAddressId, e.VendorId, e.AddressId })
                    .HasName("pk_vendor_x_address");

                entity.ToTable("vendor_x_address");

                entity.Property(e => e.VendorXAddressId)
                    .HasColumnName("vendor_x_address_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.VendorId).HasColumnName("vendor_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<VendorXItem>(entity =>
            {
                entity.ToTable("vendor_x_item");

                entity.HasIndex(e => new { e.ItemId, e.VendorId })
                    .HasName("idx_vendor_x_item_03_02");

                entity.HasIndex(e => new { e.VendorId, e.ItemId })
                    .HasName("idx_vendor_x_item_04");

                entity.HasIndex(e => new { e.VendorId, e.ItemId, e.Cost })
                    .HasName("idx_vendor_x_item_05");

                entity.HasIndex(e => new { e.VendorXItemId, e.Cost, e.ItemId, e.VendorId })
                    .HasName("rdx_vendor_x_item_02");

                entity.Property(e => e.VendorXItemId).HasColumnName("vendor_x_item_id");

                entity.Property(e => e.BuyingUnit)
                    .IsRequired()
                    .HasColumnName("buying_unit")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'TBD'");

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Qt)
                    .HasColumnName("qt")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VendorId)
                    .HasColumnName("vendor_id")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<VendorXManufacturer>(entity =>
            {
                entity.HasKey(e => new { e.VendorId, e.ManufacturerId })
                    .HasName("PK_vendor_x_manufacturer");

                entity.ToTable("vendor_x_manufacturer");

                entity.Property(e => e.VendorId).HasColumnName("vendor_id");

                entity.Property(e => e.ManufacturerId).HasColumnName("manufacturer_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.ToTable("warehouse");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(100);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(100);

                entity.Property(e => e.Address3)
                    .HasColumnName("address3")
                    .HasMaxLength(100);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(100);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.OrdersEmail)
                    .HasColumnName("orders_email")
                    .HasMaxLength(100);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasMaxLength(100);

                entity.Property(e => e.RfDeviceEndIp)
                    .HasColumnName("rf_device_end_ip")
                    .HasMaxLength(100);

                entity.Property(e => e.RfDeviceStartIp)
                    .HasColumnName("rf_device_start_ip")
                    .HasMaxLength(100);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<WebAlert>(entity =>
            {
                entity.ToTable("web_alert");

                entity.Property(e => e.WebAlertId).HasColumnName("web_alert_id");

                entity.Property(e => e.AlertName)
                    .HasColumnName("alert_name")
                    .HasMaxLength(100);

                entity.Property(e => e.FunctionToCall)
                    .IsRequired()
                    .HasColumnName("function_to_call")
                    .HasMaxLength(100);

                entity.Property(e => e.PermissionName)
                    .HasColumnName("permission_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(255);

                entity.Property(e => e.WebAlertTypeId).HasColumnName("web_alert_type_id");
            });

            modelBuilder.Entity<WebAlertType>(entity =>
            {
                entity.ToTable("web_alert_type");

                entity.Property(e => e.WebAlertTypeId).HasColumnName("web_alert_type_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<WmsBusiness>(entity =>
            {
                entity.ToTable("wms_business");

                entity.Property(e => e.WmsBusinessId).HasColumnName("wms_business_id");

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(100);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(100);

                entity.Property(e => e.Address3)
                    .HasColumnName("address3")
                    .HasMaxLength(100);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(100);

                entity.Property(e => e.ConnectedToWarehouse)
                    .HasColumnName("connected_to_warehouse")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CustomerTypes)
                    .HasColumnName("customer_types")
                    .HasMaxLength(20);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GenerateIwto).HasColumnName("generate_iwto");

                entity.Property(e => e.GenerateOrderLevels).HasColumnName("generate_order_levels");

                entity.Property(e => e.HasInventory)
                    .HasColumnName("has_inventory")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.OrdersEmail)
                    .HasColumnName("orders_email")
                    .HasMaxLength(100);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasMaxLength(100);

                entity.Property(e => e.RfDeviceEndIp)
                    .HasColumnName("rf_device_end_ip")
                    .HasMaxLength(100);

                entity.Property(e => e.RfDeviceStartIp)
                    .HasColumnName("rf_device_start_ip")
                    .HasMaxLength(100);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<WmsBusinessXCustomer>(entity =>
            {
                entity.ToTable("wms_business_x_customer");

                entity.Property(e => e.WmsBusinessXCustomerId).HasColumnName("wms_business_x_customer_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.WmsBusinessId).HasColumnName("wms_business_id");
            });

            modelBuilder.Entity<WmsBusinessXVendor>(entity =>
            {
                entity.ToTable("wms_business_x_vendor");

                entity.Property(e => e.WmsBusinessXVendorId).HasColumnName("wms_business_x_vendor_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VendorId).HasColumnName("vendor_id");

                entity.Property(e => e.WmsBusinessId).HasColumnName("wms_business_id");
            });

            modelBuilder.Entity<XxxUserRf>(entity =>
            {
                entity.HasKey(e => e.UserRfId)
                    .HasName("pk_user_rf");

                entity.ToTable("XXX_user_rf");

                entity.Property(e => e.UserRfId).HasColumnName("user_rf_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EquipmentTypeId).HasColumnName("equipment_type_id");

                entity.Property(e => e.FunctionState)
                    .HasColumnName("function_state")
                    .HasColumnType("ntext");

                entity.Property(e => e.LastFunction)
                    .HasColumnName("last_function")
                    .HasMaxLength(255);

                entity.Property(e => e.TerminalId)
                    .HasColumnName("terminal_id")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");
            });

            modelBuilder.Entity<Zone>(entity =>
            {
                entity.ToTable("zone");

                entity.Property(e => e.ZoneId).HasColumnName("zone_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsRetail).HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasColumnName("update_user")
                    .HasDefaultValueSql("0");
            });
        }
    }
}