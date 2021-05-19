using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class DateFormatRepository : IDateFormatRepository
    {
        private readonly DataContext dc;

        public DateFormatRepository(DataContext dc)
        {
            this.dc = dc;
        }

        public void AddDateFormat(DateFormat dateFormat)
        {
            dc.DateFormats.Add(dateFormat);
        }

        public void DeleteDateFormat(int dateFormatId)
        {
            var id = dc.DateFormats.Find(dateFormatId);
            dc.DateFormats.Remove(id);
        }

        public async Task<DateFormat> FindDateFormatAsync(int id)
        {
            return await dc.DateFormats
                .Include("WebSites.Users")
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IList<DateFormat>> GetDateFormats()
        {
            return await dc.DateFormats
                .Include("WebSites.Users")
                .ToListAsync();
        }
    }
    public interface IDateFormatRepository
    {
        void AddDateFormat(DateFormat dateFormat);
        void DeleteDateFormat(int dateFormatId);
        Task<DateFormat> FindDateFormatAsync(int id);
        Task<IList<DateFormat>> GetDateFormats();
    }
}
