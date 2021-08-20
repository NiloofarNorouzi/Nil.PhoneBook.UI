using Nil.PhoneBook.UI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nil.PhoneBook.UI.IRepository
{
    public interface IUnitOfWork  :IDisposable
    {
        IGenericRepository<User> Users { get;  }
        IGenericRepository<Contact> Contacts { get;  }
        IGenericRepository<Phone> Phones { get;  }
        IGenericRepository<Favorite> Favorites { get;  }
        Task Save();


    }
}
