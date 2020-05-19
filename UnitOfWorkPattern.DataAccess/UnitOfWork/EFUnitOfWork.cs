using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkPattern.DataAccess.EntityFramework.Contexts;
using UnitOfWorkPattern.DataAccess.Repositories;

namespace UnitOfWorkPattern.DataAccess.UnitOfWork
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly UnitOfWorkPatternContext _dbContext;

        public EFUnitOfWork(UnitOfWorkPatternContext dbContext)
        {

            if (dbContext == null)
                throw new ArgumentNullException("dbContext can not be null.");

            _dbContext = dbContext;
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new EFRepository<T>(_dbContext);
        }

        public int SaveChanges()
        {
            try
            {
                return _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }

            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
