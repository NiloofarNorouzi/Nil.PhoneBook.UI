using Nil.PhoneBook.UI.Data;
using Nil.PhoneBook.UI.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nil.PhoneBook.UI.Models
{
    public class PhoneDTO
    {
        public int PhoneId { get; set; }
        public int ContactId { get; set; }
        public Contact Contact { get; set; }

        public PhoneType PhoneType { get; set; }
        public string PhoneNumber { get; set; }
    }
}
