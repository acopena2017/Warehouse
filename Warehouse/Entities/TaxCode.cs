﻿using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class TaxCode
    {
        public int? TaxCodeIdOld { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool System { get; set; }
        public bool Expired { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int TaxCodeId { get; set; }
    }
}
