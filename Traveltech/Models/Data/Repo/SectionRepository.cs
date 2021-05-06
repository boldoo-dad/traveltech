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
        public void addSection(Section section)
        {
            dc.Sections.Add(section);
        }

        public void deleteSection(int sectionId)
        {
            var id = dc.Sections.Find(sectionId);
            dc.Sections.Remove(id);
        }

        public async Task<Section> findSectionAsync(int id)
        {
            return await dc.Sections.FindAsync(id);
        }

        public async Task<IList<Section>> getSectionsAsync()
        {
            return await dc.Sections.ToListAsync();
        }
    }
    public interface ISectionRepository
    {
        void addSection(Section section);
        void deleteSection(int sectionId);
        Task<Section> findSectionAsync(int id);
        Task<IList<Section>> getSectionsAsync();
    }
}
