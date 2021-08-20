using Nil.PhoneBook.UI.Data;
using Nil.PhoneBook.UI.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nil.PhoneBook.UI.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<User> _users;
        private IGenericRepository<Contact> _contacts;
        private IGenericRepository<Phone> _phones;
        private IGenericRepository<Favorite> _favorites;
        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }


        public IGenericRepository<User> Users => _users ??= new GenericRepository<User>(_context);
        public IGenericRepository<Contact> Contacts => _contacts ??= new GenericRepository<Contact>(_context);
        public IGenericRepository<Phone> Phones => _phones ??= new GenericRepository<Phone>(_context);
        public IGenericRepository<Favorite> Favorites => _favorites ??= new GenericRepository<Favorite>(_context);


        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
