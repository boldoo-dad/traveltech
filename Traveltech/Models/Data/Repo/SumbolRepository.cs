using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class SumbolRepository : ISumbolRepository
    {
        private readonly DataContext dc;

        public SumbolRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void AddSumbol(Sumbol sumbol)
        {
            dc.Sumbols.Add(sumbol);
        }

        public void DeleteSumbol(int sumbolId)
        {
            var id = dc.Sumbols.Find(sumbolId);
            dc.Sumbols.Remove(id);
        }


        public async Task<Sumbol> FindSumbolAsync(int id)
        {
            return await dc.Sumbols.FindAsync(id);
        }

        public async Task<IList<Sumbol>> GetSumbolsAsync()
        {
            return await dc.Sumbols.ToListAsync();
        }
    }
    public interface ISumbolRepository
    {
        void AddSumbol(Sumbol sumbol);
        void DeleteSumbol(int sumbolId);
        Task<Sumbol> FindSumbolAsync(int id);
        Task<IList<Sumbol>> GetSumbolsAsync();
    }
}
