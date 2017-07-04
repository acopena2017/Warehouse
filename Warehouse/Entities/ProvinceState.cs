using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ProvinceState
    {
        public ProvinceState()
        {
            City = new HashSet<City>();
        }

        public int ProvinceStateId { get; set; }
        public string FullName { get; set; }
        public int? CountryId { get; set; }
        public string PostalAbbreviation { get; set; }

        public virtual ICollection<City> City { get; set; }
        public virtual Country Country { get; set; }
    }
}
