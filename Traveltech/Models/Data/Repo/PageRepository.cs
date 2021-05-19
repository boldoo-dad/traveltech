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
        public void AddPage(Page page)
        {
            dc.Pages.Add(page);
        }

        public void DeletePage(int pageId)
        {
            var id = dc.Pages.Find(pageId);
            dc.Pages.Remove(id);
        }

        public async Task<Page> FindPageAsync(int id)
        {
            return await dc.Pages
                 .Include(m => m.Sections)
                 .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IList<Page>> GetPagesAsync()
        {
            return await dc.Pages
                .Include(m => m.Sections)
                .ToListAsync();
        }
    }
    public interface IPageRepository
    {
        void AddPage(Page page);
        void DeletePage(int pageId);
        Task<Page> FindPageAsync(int id);
        Task<IList<Page>> GetPagesAsync();
    }
}
