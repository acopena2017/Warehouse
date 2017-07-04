using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class GroupReplenishment
    {
        public int GroupReplenishmentId { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Closed { get; set; }
        public int PalletId { get; set; }
    }
}
