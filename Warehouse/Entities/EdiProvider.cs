using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class EdiProvider
    {
        public EdiProvider()
        {
            Customer = new HashSet<Customer>();
            CustomerXEdiLocationCode = new HashSet<CustomerXEdiLocationCode>();
        }

        public int EdiProviderId { get; set; }
        public string EdiName { get; set; }
        public string EdiDescription { get; set; }
        public bool? HasLocationCodes { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<CustomerXEdiLocationCode> CustomerXEdiLocationCode { get; set; }
    }
}
