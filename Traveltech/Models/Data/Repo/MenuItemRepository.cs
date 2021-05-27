using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private readonly DataContext dc;

        public MenuItemRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void AddMenuItem(MenuItem menuItem)
        {
            dc.MenuItems.Add(menuItem);
        }

        public void DeleteMenuItem(int menuItemId)
        {
            var id = dc.MenuItems.Find(menuItemId);
            dc.MenuItems.Remove(id);
        }

        public async Task<MenuItem> FindMenuItemAsync(int id)
        {
            return await dc.MenuItems.FindAsync(id);
        }

        public async Task<IList<MenuItem>> GetMenuItemsAsync()
        {
            return await dc.MenuItems.ToListAsync();
        }
    }
    public interface IMenuItemRepository
    {
        void AddMenuItem(MenuItem menuItem);
        void DeleteMenuItem(int menuItemId);
        Task<MenuItem> FindMenuItemAsync(int id);
        Task<IList<MenuItem>> GetMenuItemsAsync();
    }
}
