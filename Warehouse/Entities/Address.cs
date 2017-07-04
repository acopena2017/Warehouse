using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public string TableName { get; set; }
        public int? TableId { get; set; }
        public int? AddressTypeId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public bool Default { get; set; }
        public bool Expired { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public int? CityId { get; set; }
        public int? ProvinceStateIdDeprecated { get; set; }

        public virtual City CityNavigation { get; set; }
    }
}
