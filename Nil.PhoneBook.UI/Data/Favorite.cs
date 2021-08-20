using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nil.PhoneBook.UI.Data
{
    public class Favorite
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FavoriteId { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }
        [ForeignKey(nameof(Contact))]
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}
