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
        public void AddCategory(Category category)
        {
            dc.Categories.Add(category);
        }

        public void DeleteCategory(int categoryId)
        {
            var id = dc.Categories.Find(categoryId);
            dc.Categories.Remove(id);
        }

        public async Task<Category> FindCategoryAsync(int id)
        {
            return await dc.Categories
                  .Include(m => m.Posts)
                  .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IList<Category>> GetCategoriesAsync()
        {
            return await dc.Categories
                .Include(m => m.Posts)
                .ToListAsync();
        }
    }
    public interface ICategoryRepository
    {
        void AddCategory(Category category);
        void DeleteCategory(int categoryId);
        Task<Category> FindCategoryAsync(int id);
        Task<IList<Category>> GetCategoriesAsync();
    }
}
