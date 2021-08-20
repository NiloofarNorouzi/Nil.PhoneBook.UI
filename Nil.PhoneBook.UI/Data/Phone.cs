using Nil.PhoneBook.UI.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nil.PhoneBook.UI.Data
{
    public class Phone
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PhoneId { get; set; }
        [ForeignKey(nameof(Contact))]
        public int ContactId { get; set; }
        public Contact Contact { get; set; }

        public PhoneType PhoneType { get; set; }
        public string PhoneNumber { get; set; }
}
}
