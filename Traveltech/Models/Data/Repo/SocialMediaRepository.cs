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
        public void addSocialMedia(SocialMedia socialMedia)
        {
            dc.SocialMedias.Add(socialMedia);
        }

        public void deleteSocialMedia(int socialMediaId)
        {
            var id = dc.SocialMedias.Find(socialMediaId);
            dc.SocialMedias.Remove(id);
        }

        public async Task<SocialMedia> findSocialMediaAsync(int id)
        {
            return await dc.SocialMedias.FindAsync(id);
        }

        public async Task<IList<SocialMedia>> getSocialMediasAsync()
        {
            return await dc.SocialMedias.ToListAsync();
        }
    }
    public interface ISocialMediaRepository
    {
        void addSocialMedia(SocialMedia socialMedia);
        void deleteSocialMedia(int socialMediaId);
        Task<SocialMedia> findSocialMediaAsync(int id);
        Task<IList<SocialMedia>> getSocialMediasAsync();
    }
}
