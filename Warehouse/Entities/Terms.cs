using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class Terms
    {
        public int TermsId { get; set; }
        public string Description { get; set; }
        public bool DateDriven { get; set; }
        public string CrossoverDay { get; set; }
        public string DayDue { get; set; }
        public string P1PercentDue { get; set; }
        public string P1Days { get; set; }
        public string P2PercentDue { get; set; }
        public string P2Days { get; set; }
        public string P3PercentDue { get; set; }
        public string P3Days { get; set; }
        public bool Expired { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
    }
}
