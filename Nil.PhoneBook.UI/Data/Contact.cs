using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nil.PhoneBook.UI.Data
{
    public class Contact    
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
