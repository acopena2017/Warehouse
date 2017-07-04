using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class AconnexBuyer
    {
        public int AconnexBuyerId { get; set; }
        public int CustomerId { get; set; }
        public string BuyerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
