using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class Country
    {
        public Country()
        {
            ProvinceState = new HashSet<ProvinceState>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool System { get; set; }
        public bool Expired { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public int? IsoCountryCode { get; set; }
        public string IsoAbbr2 { get; set; }
        public string IsoAbbr3 { get; set; }

        public virtual ICollection<ProvinceState> ProvinceState { get; set; }
    }
}
