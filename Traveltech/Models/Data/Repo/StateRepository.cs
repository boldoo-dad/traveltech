using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class StateRepository : IStateRepository
    {
        private readonly DataContext dc;

        public StateRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void AddState(State state)
        {
            dc.States.Add(state);
        }

        public void DeleteState(int stateId)
        {
            var id = dc.States.Find(stateId);
            dc.States.Remove(id);
        }

        public async Task<State> FindStateAsync(int id)
        {
            return await dc.States
                 .Include(m => m.Cities)
                 .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IList<State>> GetStatesAsync()
        {
            return await dc.States
                .Include(m => m.Cities)
                .ToListAsync();
        }
    }
    public interface IStateRepository
    {
        void AddState(State state);
        void DeleteState(int stateId);
        Task<State> FindStateAsync(int id);
        Task<IList<State>> GetStatesAsync();
    }
}
