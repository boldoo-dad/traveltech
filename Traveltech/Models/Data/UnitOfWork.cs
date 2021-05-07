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

        public ISectionRepository SectionRepository =>
            new SectionRepository(dc);

        public IHomePagesRepository HomePagesRepository =>
            new HomePagesRepository(dc);

        public ICategoryRepository CategoryRepository =>
            new CategoryRepository(dc);

        public IPostRepository PostRepository =>
            new PostRepository(dc);

        public async Task<bool> SaveAsync()
        {
            return await dc.SaveChangesAsync() > 0;
        }
    }
    public interface IUnitOfWork
    {
        IPostRepository PostRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IHomePagesRepository HomePagesRepository { get; }
        ISectionRepository SectionRepository { get; }
        IPageRepository PageRepository { get; }
        Task<bool> SaveAsync();
    }
}
