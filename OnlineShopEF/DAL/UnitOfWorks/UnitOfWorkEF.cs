using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShopEF.DAL
{
    public class UnitOfWorkEF : IUnitOfWork
    {
        private OnlineShopContext _dbContext;
        private Dictionary<string, object> _repositories;
        private bool _disposed = false;

        public UnitOfWorkEF()
        {
            _dbContext = new OnlineShopContext();
            _repositories = new Dictionary<string, object>();
        }

        public BaseRepository<T> Repository<T>() where T : class
        {
            Type t = typeof(BaseRepository<T>);
            if (_repositories.ContainsKey(t.FullName))
                return (BaseRepository<T>)Convert.ChangeType(_repositories.First(r => r.Key == t.FullName), t);
            else
                return (BaseRepository<T>)Convert.ChangeType(Activator.CreateInstance(t, _dbContext), t);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                    _repositories.Clear();
                    _repositories = null;
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
