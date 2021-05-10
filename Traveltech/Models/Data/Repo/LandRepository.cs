using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class LandRepository : ILandRepository
    {
        private readonly DataContext dc;

        public LandRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void addLand(Land land)
        {
            dc.Lands.Add(land);
        }

        public void deleteLand(int landId)
        {
            var id = dc.Lands.Find(landId);
            dc.Lands.Remove(id);
        }


        public async Task<Land> findLandAsync(int id)
        {
            return await dc.Lands
                .Include("States.Cities")
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IList<Land>> getLandsAsync()
        {
            return await dc.Lands
                .Include("States.Cities")
                .ToListAsync();
        }
    }
    public interface ILandRepository
    {
        void addLand(Land land);
        void deleteLand(int landId);
        Task<Land> findLandAsync(int id);
        Task<IList<Land>> getLandsAsync();
    }
}
