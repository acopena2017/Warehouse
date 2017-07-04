using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class City
    {
        public City()
        {
            Address = new HashSet<Address>();
        }

        public int CityId { get; set; }
        public int? ProvinceStateId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ProvinceState ProvinceState { get; set; }
    }
}
