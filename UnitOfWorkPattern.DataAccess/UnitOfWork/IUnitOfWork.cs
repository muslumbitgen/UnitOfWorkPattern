using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkPattern.DataAccess.Repositories;

namespace UnitOfWorkPattern.DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;
        int SaveChanges();
    }
}
