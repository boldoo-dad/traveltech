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
        public void addPost(Post post)
        {
            dc.Posts.Add(post);
        }

        public void deletePost(int postId)
        {
            var id = dc.Posts.Find(postId);
            dc.Posts.Remove(id);
        }

        public async Task<Post> findPostAsync(int id)
        {
            return await dc.Posts
                 .Include(m => m.Categories)
                 .FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task<IList<Post>> getPostsAsync()
        {
            return await dc.Posts
                .Include(m => m.Categories)
                .ToListAsync();
        }
    }
    public interface IPostRepository
    {
        void addPost(Post post);
        void deletePost(int postId);
        Task<Post> findPostAsync(int id);
        Task<IList<Post>> getPostsAsync();
    }
}
