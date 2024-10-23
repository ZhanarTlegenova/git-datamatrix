using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EFModel
{
    public class Contact
    {
        [Key]
        public System.Guid ContactId { set; get; }
        public string ContactName { get; set; }
        public string ContactLName { get; set; }
        public string ContactNumber { get; set; }
        public string CotactEmail { get; set; }
    }
}
