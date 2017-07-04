using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class UserPriceListOutput
    {
        public int UserPriceListOutputId { get; set; }
        public string CategoryId { get; set; }
        public int SubmitType { get; set; }
        public int PresetId { get; set; }
        public int BusinessSizeId { get; set; }
        public int ClientTypeId { get; set; }
        public int CustomerTypeId { get; set; }
        public int PriceListId { get; set; }
        public int JobStatus { get; set; }
        public DateTime? PriceListEffectiveDate { get; set; }
        public int PriceListToSend { get; set; }
        public string PriceListOutputName { get; set; }
        public string EmailText { get; set; }
        public string ExcelFilename { get; set; }
        public string PdfFilename { get; set; }
        public int UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int ConfirmUserId { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public bool EmailFilter { get; set; }
        public bool? IncludeApplication { get; set; }
    }
}
