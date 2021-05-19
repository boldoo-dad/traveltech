using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class PostRepository : IPostRepository
    {
        private readonly DataContext dc;

        public PostRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void AddPost(Post post)
        {
            dc.Posts.Add(post);
        }

        public void DeletePost(int postId)
        {
            var id = dc.Posts.Find(postId);
            dc.Posts.Remove(id);
        }

        public async Task<Post> FindPostAsync(int id)
        {
            return await dc.Posts
                 .Include(m => m.Categories)
                 .FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task<IList<Post>> GetPostsAsync()
        {
            return await dc.Posts
                .Include(m => m.Categories)
                .ToListAsync();
        }
    }
    public interface IPostRepository
    {
        void AddPost(Post post);
        void DeletePost(int postId);
        Task<Post> FindPostAsync(int id);
        Task<IList<Post>> GetPostsAsync();
    }
}
