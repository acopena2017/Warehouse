using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class User
    {
        public User()
        {
            ExternalTransferCreateUser = new HashSet<ExternalTransfer>();
            ExternalTransferDriverUser = new HashSet<ExternalTransfer>();
            ExternalTransferPickUser = new HashSet<ExternalTransfer>();
            ExternalTransferReceiveUser = new HashSet<ExternalTransfer>();
            ExternalTransferRequestUser = new HashSet<ExternalTransfer>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? TotalLogins { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool PickHigh { get; set; }
        public bool PickHeavy { get; set; }
        public bool Expired { get; set; }
        public string Email { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public bool IsGarysStore { get; set; }
        public int DefaultWarehouseId { get; set; }
        public bool? PickQuick { get; set; }
        public bool? PickPriority { get; set; }
        public bool IsDriver { get; set; }
        public bool? PickReserveOrder { get; set; }

        public virtual ICollection<ExternalTransfer> ExternalTransferCreateUser { get; set; }
        public virtual ICollection<ExternalTransfer> ExternalTransferDriverUser { get; set; }
        public virtual ICollection<ExternalTransfer> ExternalTransferPickUser { get; set; }
        public virtual ICollection<ExternalTransfer> ExternalTransferReceiveUser { get; set; }
        public virtual ICollection<ExternalTransfer> ExternalTransferRequestUser { get; set; }
    }
}
