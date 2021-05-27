using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class MenuRepository : IMenuRepository
    {
        private readonly DataContext dc;
        public MenuRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void AddMenu(Menu menu)
        {
            dc.Menus.Add(menu);
        }
        public void DeleteMenu(int menuId)
        {
            var id = dc.Menus.Find(menuId);
            dc.Menus.Remove(id);
        }
        public async Task<Menu> FindMenuAsync(int id)
        {
            return await dc.Menus
                  .Include(m => m.MenuItems)
                  .FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task<IList<Menu>> GetMenusAsync()
        {
            return await dc.Menus
                 .Include(m => m.MenuItems)
                 .ToListAsync();
        }
    }
    public interface IMenuRepository
    {
        void AddMenu(Menu menu);
        void DeleteMenu(int menuId);
        Task<Menu> FindMenuAsync(int id);
        Task<IList<Menu>> GetMenusAsync();
    }
}
