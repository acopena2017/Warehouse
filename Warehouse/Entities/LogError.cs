using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class LogError
    {
        public int LogErrorId { get; set; }
        public string LogErrorSrc { get; set; }
        public string LogErrorDesc { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
    }
}
