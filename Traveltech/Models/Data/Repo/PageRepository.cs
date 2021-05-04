using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class PageRepository : IPageRepository
    {
        private readonly DataContext dc;

        public PageRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void addPage(Page page)
        {
            dc.Pages.Add(page);
        }

        public void deletePage(int pageId)
        {
            var id = dc.Pages.Find(pageId);
            dc.Pages.Remove(id);
        }

        public async Task<Page> findPageAsync(int id)
        {
            return await dc.Pages
                 .Include(m => m.Sections)
                 .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IList<Page>> getPagesAsync()
        {
            return await dc.Pages
                .Include(m => m.Sections)
                .ToListAsync();
        }
    }
    public interface IPageRepository
    {
        void addPage(Page page);
        void deletePage(int pageId);
        Task<Page> findPageAsync(int id);
        Task<IList<Page>> getPagesAsync();
    }
}
