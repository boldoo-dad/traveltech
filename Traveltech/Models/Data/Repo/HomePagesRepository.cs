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
        public void addHomePage(HomePage homePage)
        {
            dc.HomePages.Add(homePage);
        }

        public void deleteHomePage(int homePageId)
        {
            var id = dc.HomePages.Find(homePageId);
            dc.HomePages.Remove(id);
        }

        public async Task<HomePage> findHomePageAsync(int id)
        {
            return await dc.HomePages
                .Include(m => m.Sections)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IList<HomePage>> getHomePagesAsync()
        {
            return await dc.HomePages
                .Include(m => m.Sections)
                .ToListAsync();
        }
    }
    public interface IHomePagesRepository
    {
        void addHomePage(HomePage homePage);
        void deleteHomePage(int homePageId);
        Task<HomePage> findHomePageAsync(int id);
        Task<IList<HomePage>> getHomePagesAsync();
    }
}
