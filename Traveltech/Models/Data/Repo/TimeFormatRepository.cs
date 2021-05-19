using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class TimeFormatRepository : ITimeFormatRepository
    {
        private readonly DataContext dc;

        public TimeFormatRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void AddTimeFormat(TimeFormat timeFormat)
        {
            dc.TimeFormats.Add(timeFormat);
        }

        public void DeleteTimeFormat(int timeFormat)
        {
            var id = dc.TimeFormats.Find(timeFormat);
            dc.TimeFormats.Remove(id);
        }

        public async Task<TimeFormat> FindTimeFormatAsync(int id)
        {
            return await dc.TimeFormats.FindAsync(id);
        }

        public async Task<IList<TimeFormat>> GetTimeFormats()
        {
            return await dc.TimeFormats.ToListAsync();
        }
    }
    public interface ITimeFormatRepository
    {
        void AddTimeFormat(TimeFormat timeFormat);
        void DeleteTimeFormat(int timeFormat);
        Task<TimeFormat> FindTimeFormatAsync(int id);
        Task<IList<TimeFormat>> GetTimeFormats();
    }
}
