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
        public void AddWebSite(WebSite webSite)
        {
            dc.WebSites.Add(webSite);
        }

        public void DeleteWebSite(int webSiteId)
        {
            var id = dc.WebSites.Find(webSiteId);
            dc.WebSites.Remove(id);
        }

        public async Task<WebSite> FindWebSiteAsync(int id)
        {
            return await dc.WebSites
                .Include(m => m.Users)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IList<WebSite>> GetWebSitesAsync()
        {
            return await dc.WebSites
                .Include(m => m.Users)
                .ToListAsync();
        }
    }
    public interface IWebSiteRepository
    {
        void AddWebSite(WebSite webSite);
        void DeleteWebSite(int webSiteId);
        Task<WebSite> FindWebSiteAsync(int id);
        Task<IList<WebSite>> GetWebSitesAsync();
    }
}
