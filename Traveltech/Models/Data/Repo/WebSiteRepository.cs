using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class WebSiteRepository : IWebSiteRepository
    {
        private readonly DataContext dc;

        public WebSiteRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void addWebSite(WebSite webSite)
        {
            dc.WebSites.Add(webSite);
        }

        public void deleteWebSite(int webSiteId)
        {
            var id = dc.WebSites.Find(webSiteId);
            dc.WebSites.Remove(id);
        }

        public async Task<WebSite> findWebSiteAsync(int id)
        {
            return await dc.WebSites
                .Include(m => m.Users)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IList<WebSite>> getWebSitesAsync()
        {
            return await dc.WebSites
                .Include(m => m.Users)
                .ToListAsync();
        }
    }
    public interface IWebSiteRepository
    {
        void addWebSite(WebSite webSite);
        void deleteWebSite(int webSiteId);
        Task<WebSite> findWebSiteAsync(int id);
        Task<IList<WebSite>> getWebSitesAsync();
    }
}
