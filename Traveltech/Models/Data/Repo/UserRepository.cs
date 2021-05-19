using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext dc;

        public UserRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void AddUser(User user)
        {
            dc.Users.Add(user);
        }

        public void DeleteUser(int userId)
        {
            var id = dc.Users.Find(userId);
            dc.Users.Remove(id);
        }

        public async Task<User> FindUserAsync(int id)
        {
            return await dc.Users.FindAsync(id);
        }

        public async Task<IList<User>> GetUsersAsync()
        {
            return await dc.Users.ToListAsync();
        }
    }
    public interface IUserRepository
    {
        void AddUser(User user);
        void DeleteUser(int userId);
        Task<User> FindUserAsync(int id);
        Task<IList<User>> GetUsersAsync();
    }
}
