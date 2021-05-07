using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext dc;

        public CategoryRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void addCategory(Category category)
        {
            dc.Categories.Add(category);
        }

        public void deleteCategory(int categoryId)
        {
            var id = dc.Categories.Find(categoryId);
            dc.Categories.Remove(id);
        }

        public async Task<Category> findCategoryAsync(int id)
        {
            return await dc.Categories
                  .Include(m => m.Posts)
                  .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IList<Category>> getCategoriesAsync()
        {
            return await dc.Categories
                .Include(m => m.Posts)
                .ToListAsync();
        }
    }
    public interface ICategoryRepository
    {
        void addCategory(Category category);
        void deleteCategory(int categoryId);
        Task<Category> findCategoryAsync(int id);
        Task<IList<Category>> getCategoriesAsync();
    }
}
