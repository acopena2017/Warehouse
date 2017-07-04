using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            AconnexBuyer = new HashSet<AconnexBuyer>();
            CustomerXCostPlus = new HashSet<CustomerXCostPlus>();
            CustomerXEdiLocationCode = new HashSet<CustomerXEdiLocationCode>();
            ExternalTransfer = new HashSet<ExternalTransfer>();
        }

        public int CustomerId { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public int? CustomerTypeId { get; set; }
        public string Currency { get; set; }
        public decimal? CreditLimit { get; set; }
        public bool CreditHold { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public bool SendPartialShipments { get; set; }
        public bool HoldBackOrders { get; set; }
        public bool UsesQuickpicks { get; set; }
        public bool ScheduledDelivery { get; set; }
        public int? TermsId { get; set; }
        public int? TaxCodeId { get; set; }
        public string FederalNumber { get; set; }
        public string GstNumber { get; set; }
        public string PstNumber { get; set; }
        public bool Expired { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public int ClientTypeId { get; set; }
        public int? BusinessSizeId { get; set; }
        public int? SalesQualificationId { get; set; }
        public string City { get; set; }
        public int? ProvinceStateId { get; set; }
        public int? CountryId { get; set; }
        public int InvoiceSendTypeId { get; set; }
        public int DefaultWarehouse { get; set; }
        public bool? UseDirectShip { get; set; }
        public DateTime? AnniversaryDate { get; set; }
        public string CcInfo { get; set; }
        public bool BlockPalletPricing { get; set; }
        public int? EdiProviderId { get; set; }
        public bool? CanVerifyAndShip { get; set; }
        public int? ShippingCompanyId { get; set; }
        public bool? EmailOnQueue { get; set; }
        public int? PickingZoneId1 { get; set; }
        public int? PickingZoneId2 { get; set; }
        public int? PickingZoneId3 { get; set; }
        public int? PickingZoneId4 { get; set; }
        public int? PickingZoneId5 { get; set; }
        public bool ExcludeForecast { get; set; }
        public bool IsAutoPriority { get; set; }
        public bool Intercompany { get; set; }
        public bool ExternalStoreFront { get; set; }
        public int? ExternalTransferBinId { get; set; }
        public int? BuyoutBinId { get; set; }
        public bool? UseSinglePallet { get; set; }
        public int? SalesChannelId { get; set; }

        public virtual ICollection<AconnexBuyer> AconnexBuyer { get; set; }
        public virtual ICollection<CustomerXCostPlus> CustomerXCostPlus { get; set; }
        public virtual ICollection<CustomerXEdiLocationCode> CustomerXEdiLocationCode { get; set; }
        public virtual ICollection<ExternalTransfer> ExternalTransfer { get; set; }
        public virtual EdiProvider EdiProvider { get; set; }
    }
}
