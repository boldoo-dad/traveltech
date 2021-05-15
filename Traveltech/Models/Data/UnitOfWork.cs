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

        public IAddressRepository AddressRepository =>
            new AddressRepository(dc);

        public ICityRepository CityRepository =>
            new CityRepository(dc);

        public IStateRepository StateRepository =>
            new StateRepository(dc);

        public ILandRepository LandRepository =>
            new LandRepository(dc);

        public IContactRepository ContactRepository =>
            new ContactRepository(dc);

        public ISumbolRepository SumbolRepository =>
            new SumbolRepository(dc);

        public ISocialMediaRepository SocialMediaRepository =>
            new SocialMediaRepository(dc);

        public async Task<bool> SaveAsync()
        {
            return await dc.SaveChangesAsync() > 0;
        }
    }
    public interface IUnitOfWork
    {
        ISocialMediaRepository SocialMediaRepository { get; }
        ISumbolRepository SumbolRepository { get; }
        IContactRepository ContactRepository { get; }
        ILandRepository LandRepository { get; }
        IStateRepository StateRepository { get; }
        ICityRepository CityRepository { get; }
        IAddressRepository AddressRepository { get; }
        IPostRepository PostRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IHomePagesRepository HomePagesRepository { get; }
        ISectionRepository SectionRepository { get; }
        IPageRepository PageRepository { get; }
        Task<bool> SaveAsync();
    }
}
