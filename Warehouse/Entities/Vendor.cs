using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class Vendor
    {
        public Vendor()
        {
            ShippingQuote = new HashSet<ShippingQuote>();
        }

        public int VendorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? VendorTypeId { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Currency { get; set; }
        public int? TaxCodeId { get; set; }
        public int? CountryId { get; set; }
        public bool Expired { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public string VendorExportCode { get; set; }
        public bool? IsBuyoutVendor { get; set; }
        public int? OnOrderDays { get; set; }
        public string ManufacturerName { get; set; }
        public string Addcase { get; set; }
        public decimal? Duty { get; set; }
        public int? NetsuiteVendorExternalId { get; set; }

        public virtual ICollection<ShippingQuote> ShippingQuote { get; set; }
    }
}
