using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nil.PhoneBook.UI.Data
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string   LastName { get; set; }
        public string   UserName { get; set; }
        public string   Password { get; set; }

    }
}
