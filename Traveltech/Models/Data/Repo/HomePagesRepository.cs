using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class HomePagesRepository : IHomePagesRepository
    {
        private readonly DataContext dc;

        public HomePagesRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void AddHomePage(HomePage homePage)
        {
            dc.HomePages.Add(homePage);
        }

        public void DeleteHomePage(int homePageId)
        {
            var id = dc.HomePages.Find(homePageId);
            dc.HomePages.Remove(id);
        }

        public async Task<HomePage> FindHomePageAsync(int id)
        {
            return await dc.HomePages
                .Include(m => m.Sections)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IList<HomePage>> GetHomePagesAsync()
        {
            return await dc.HomePages
                .Include(m => m.Sections)
                .ToListAsync();
        }
    }
    public interface IHomePagesRepository
    {
        void AddHomePage(HomePage homePage);
        void DeleteHomePage(int homePageId);
        Task<HomePage> FindHomePageAsync(int id);
        Task<IList<HomePage>> GetHomePagesAsync();
    }
}
