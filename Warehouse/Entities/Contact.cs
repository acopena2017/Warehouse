using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class Contact
    {
        public int ContactId { get; set; }
        public string TableName { get; set; }
        public double? TableId { get; set; }
        public double? ContactTypeId { get; set; }
        public string Title { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public bool Default { get; set; }
        public bool Expired { get; set; }
        public DateTime? CreateDate { get; set; }
        public double? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
    }
}
