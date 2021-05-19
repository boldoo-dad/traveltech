using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class SocialMediaRepository : ISocialMediaRepository
    {
        private readonly DataContext dc;

        public SocialMediaRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void AddSocialMedia(SocialMedia socialMedia)
        {
            dc.SocialMedias.Add(socialMedia);
        }

        public void DeleteSocialMedia(int socialMediaId)
        {
            var id = dc.SocialMedias.Find(socialMediaId);
            dc.SocialMedias.Remove(id);
        }

        public async Task<SocialMedia> FindSocialMediaAsync(int id)
        {
            return await dc.SocialMedias.FindAsync(id);
        }

        public async Task<IList<SocialMedia>> GetSocialMediasAsync()
        {
            return await dc.SocialMedias.ToListAsync();
        }
    }
    public interface ISocialMediaRepository
    {
        void AddSocialMedia(SocialMedia socialMedia);
        void DeleteSocialMedia(int socialMediaId);
        Task<SocialMedia> FindSocialMediaAsync(int id);
        Task<IList<SocialMedia>> GetSocialMediasAsync();
    }
}
