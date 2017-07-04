using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class Email
    {
        public int EmailId { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string EntityName { get; set; }
        public int? EntityId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
    }
}
