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
        public void addState(State state)
        {
            dc.States.Add(state);
        }

        public void deleteState(int stateId)
        {
            var id = dc.States.Find(stateId);
            dc.States.Remove(id);
        }

        public async Task<State> findStateAsync(int id)
        {
            return await dc.States
                 .Include(m => m.Cities)
                 .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IList<State>> getStatesAsync()
        {
            return await dc.States
                .Include(m => m.Cities)
                .ToListAsync();
        }
    }
    public interface IStateRepository
    {
        void addState(State state);
        void deleteState(int stateId);
        Task<State> findStateAsync(int id);
        Task<IList<State>> getStatesAsync();
    }
}
