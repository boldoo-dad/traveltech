using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class FooterRepository : IFooterRepository
    {
        private readonly DataContext dc;

        public FooterRepository(DataContext dc)
        {
            this.dc = dc;
        }

        public void AddFooter(Footer footer)
        {
            dc.Footers.Add(footer);
        }

        public void DeleteFooter(int footerId)
        {
            var id = dc.Footers.Find(footerId);
            dc.Footers.Remove(id);
        }

        public async Task<Footer> FindFooterAsync(int id)
        {
            return await dc.Footers
                .Include("Menus.MenuItems")
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IList<Footer>> GetFootersAsync()
        {
            return await dc.Footers
                 .Include("Menus.MenuItems")
                 .ToListAsync();
        }
    }
    public interface IFooterRepository
    {
        void AddFooter(Footer footer);
        void DeleteFooter(int footerId);
        Task<Footer> FindFooterAsync(int id);
        Task<IList<Footer>> GetFootersAsync();
    }
}
