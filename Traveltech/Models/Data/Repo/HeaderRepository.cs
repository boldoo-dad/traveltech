using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class HeaderRepository : IHeaderRepository
    {
        private readonly DataContext dc;

        public HeaderRepository(DataContext dc)
        {
            this.dc = dc;
        }

        public void AddHeader(Header header)
        {
            dc.Headers.Add(header);
        }

        public void DeleteHeader(int headerId)
        {
            var id = dc.Headers.Find(headerId);
            dc.Headers.Remove(id);
        }

        public async Task<Header> FindHeaderAsync(int id)
        {
            return await dc.Headers
                .Include("Menus.MenuItems")
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IList<Header>> GetHeadersAsync()
        {
            return await dc.Headers
                 .Include("Menus.MenuItems")
                 .ToListAsync();
        }
    }
    public interface IHeaderRepository
    {
        void AddHeader(Header header);
        void DeleteHeader(int headerId);
        Task<Header> FindHeaderAsync(int id);
        Task<IList<Header>> GetHeadersAsync();
    }
}
