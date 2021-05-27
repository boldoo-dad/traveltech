using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class PositionRepository : IPositionRepository
    {
        private readonly DataContext dc;

        public PositionRepository(DataContext dc)
        {
            this.dc = dc;
        }

        public void AddPosition(Position position)
        {
            dc.Positions.Add(position);
        }

        public void DeletePosition(int positionId)
        {
            var id = dc.Positions.Find(positionId);
            dc.Positions.Remove(id);
        }

        public async Task<Position> FindPositionAsync(int id)
        {
            return await dc.Positions
                        .Include(m => m.Positions)
                        .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IList<Position>> GetPositionsAsync()
        {
            return await dc.Positions
                  .Include(m => m.Positions)
                  .ToListAsync();
        }
    }
    public interface IPositionRepository
    {
        void AddPosition(Position position);
        void DeletePosition(int positionId);
        Task<Position> FindPositionAsync(int id);
        Task<IList<Position>> GetPositionsAsync();
    }
}
