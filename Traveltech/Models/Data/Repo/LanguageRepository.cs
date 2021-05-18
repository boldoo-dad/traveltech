using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly DataContext dc;

        public LanguageRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void addLanguage(Language language)
        {
            dc.Languages.Add(language);
        }

        public void deleteLanguage(int languageId)
        {
            var id = dc.Languages.Find(languageId);
            dc.Languages.Remove(id);
        }

        public async Task<Language> findLanguageAsync(int id)
        {
            return await dc.Languages
                 .Include("Websites.Users")
                 .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IList<Language>> getLanguages()
        {
            return await dc.Languages
                .Include("Websites.Users")
                .ToListAsync();
        }
    }
    public interface ILanguageRepository
    {
        void addLanguage(Language language);
        void deleteLanguage(int languageId);
        Task<Language> findLanguageAsync(int id);
        Task<IList<Language>> getLanguages();
    }
}
