using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShopEF.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        BaseRepository<T> Repository<T>() where T : class;
        void Save();
    }
}
