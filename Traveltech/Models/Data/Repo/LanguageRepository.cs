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
        public void AddLanguage(Language language)
        {
            dc.Languages.Add(language);
        }

        public void DeleteLanguage(int languageId)
        {
            var id = dc.Languages.Find(languageId);
            dc.Languages.Remove(id);
        }

        public async Task<Language> FindLanguageAsync(int id)
        {
            return await dc.Languages
                 .Include("Websites.Users")
                 .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IList<Language>> GetLanguages()
        {
            return await dc.Languages
                .Include("Websites.Users")
                .ToListAsync();
        }
    }
    public interface ILanguageRepository
    {
        void AddLanguage(Language language);
        void DeleteLanguage(int languageId);
        Task<Language> FindLanguageAsync(int id);
        Task<IList<Language>> GetLanguages();
    }
}
