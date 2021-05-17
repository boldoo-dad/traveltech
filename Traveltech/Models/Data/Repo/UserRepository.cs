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
        public void addUser(User user)
        {
            dc.Users.Add(user);
        }

        public void deleteUser(int userId)
        {
            var id = dc.Users.Find(userId);
            dc.Users.Remove(id);
        }

        public async Task<User> findUserAsync(int id)
        {
            return await dc.Users.FindAsync(id);
        }

        public async Task<IList<User>> getUsersAsync()
        {
            return await dc.Users.ToListAsync();
        }
    }
    public interface IUserRepository
    {
        void addUser(User user);
        void deleteUser(int userId);
        Task<User> findUserAsync(int id);
        Task<IList<User>> getUsersAsync();
    }
}
