using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class Uspsorders
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerZip { get; set; }
        public string CustomerState { get; set; }
        public DateTime? UspsManifestDate { get; set; }
        public int SoId { get; set; }
        public string CustomerCity { get; set; }
        public decimal? Uspscost { get; set; }
        public int? BoxCount { get; set; }
    }
}
