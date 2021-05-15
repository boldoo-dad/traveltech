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
        public void addSumbol(Sumbol sumbol)
        {
            dc.Sumbols.Add(sumbol);
        }

        public void deleteSumbol(int sumbolId)
        {
            var id = dc.Sumbols.Find(sumbolId);
            dc.Sumbols.Remove(id);
        }


        public async Task<Sumbol> findSumbolAsync(int id)
        {
            return await dc.Sumbols.FindAsync(id);
        }

        public async Task<IList<Sumbol>> getSumbolsAsync()
        {
            return await dc.Sumbols.ToListAsync();
        }
    }
    public interface ISumbolRepository
    {
        void addSumbol(Sumbol sumbol);
        void deleteSumbol(int sumbolId);
        Task<Sumbol> findSumbolAsync(int id);
        Task<IList<Sumbol>> getSumbolsAsync();
    }
}
