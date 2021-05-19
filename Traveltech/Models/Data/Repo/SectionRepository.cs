using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class SectionRepository : ISectionRepository
    {
        private readonly DataContext dc;

        public SectionRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void AddSection(Section section)
        {
            dc.Sections.Add(section);
        }

        public void DeleteSection(int sectionId)
        {
            var id = dc.Sections.Find(sectionId);
            dc.Sections.Remove(id);
        }

        public async Task<Section> FindSectionAsync(int id)
        {
            return await dc.Sections.FindAsync(id);
        }

        public async Task<IList<Section>> GetSectionsAsync()
        {
            return await dc.Sections.ToListAsync();
        }
    }
    public interface ISectionRepository
    {
        void AddSection(Section section);
        void DeleteSection(int sectionId);
        Task<Section> FindSectionAsync(int id);
        Task<IList<Section>> GetSectionsAsync();
    }
}
