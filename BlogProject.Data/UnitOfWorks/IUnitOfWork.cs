using BlogProject.Core.Entities;
using BlogProject.Data.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Data.UnitOfWorks
{
    public interface IUnitOfWork :IAsyncDisposable
    {
        IGenericRepository<T> GetRepository<T>() where T : class, IEntityBase, new();

        Task<int> SaveAsync();
        int Save();
    }
}
