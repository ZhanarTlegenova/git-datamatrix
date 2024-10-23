using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4
{
    public class Contact
    {
        [Key]
        public int ContactId { set; get; }
        public string ContactName { get; set; } = string.Empty;
        public string ContactLName { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;

        public string ContactEmail { get; set;} = string.Empty;

    }
}
