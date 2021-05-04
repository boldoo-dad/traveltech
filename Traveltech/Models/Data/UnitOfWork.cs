using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traveltech.Models.Data.Repo;

namespace Traveltech.Models.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext dc;

        public UnitOfWork(DataContext dc)
        {
            this.dc = dc;
        }
        public IPageRepository PageRepository =>
            new PageRepository(dc);

        public async Task<bool> SaveAsync()
        {
            return await dc.SaveChangesAsync() > 0;
        }
    }
    public interface IUnitOfWork
    {
        IPageRepository PageRepository { get; }
        Task<bool> SaveAsync();
    }
}
