using Microsoft.EntityFrameworkCore;
using Nil.PhoneBook.UI.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nil.PhoneBook.UI.Data
{

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId=1,
                    FirstName = "Niloofar",
                    LastName = "Norouzi",
                    UserName = "n.norouzi",
                    Password = "123"
                },
                 new User
                 {
                     UserId=2,
                     FirstName = "Alireza",
                     LastName = "Norouzi",
                     UserName = "a.norouzi",
                     Password = "123"
                 }
                );


            modelBuilder.Entity<Contact>().HasData(
                          new Contact
                          {
                              ContactId = 1,
                              FirstName = "Niloofar",
                              LastName = "Norouzi"
                          },
                           new Contact
                           {
                               ContactId = 2,
                               FirstName = "Alireza",
                               LastName = "Norouzi"
                           }
                          );


            modelBuilder.Entity<Phone>().HasData(
                          new Phone
                          {
                              PhoneId = 1,
                              ContactId=1,
                              PhoneType = PhoneType.Mobile,
                              PhoneNumber = "09123018276"
                          },
                           new Phone
                           {
                               PhoneId = 2,
                               ContactId=1,
                               PhoneType = PhoneType.Phone,
                               PhoneNumber = "66025634"
                           }
                          );

            modelBuilder.Entity<Favorite>().HasData(
                          new Favorite
                          {
                              FavoriteId = 1,
                              UserId = 1,
                              ContactId =1
                          }
                          );

        }
    }
}
