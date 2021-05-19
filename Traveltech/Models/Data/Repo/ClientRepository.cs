using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class ClientRepository : IClientRepository
    {
        private readonly DataContext dc;

        public ClientRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void AddClient(Client client)
        {
            dc.Clients.Add(client);
        }

        public void DeleteClient(int clientId)
        {
            var id = dc.Clients.Find(clientId);
            dc.Clients.Remove(id);
        }

        public async Task<Client> FindClientAsync(int id)
        {
            return await dc.Clients
                .Include("WebSites.Users")
                .Include(m => m.Users)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IList<Client>> GetClientsAsync()
        {
            return await dc.Clients
               .Include("WebSites.Users")   
               .Include(m => m.Users)
               .ToListAsync();
        }
    }
    public interface IClientRepository
    {
        void AddClient(Client client);
        void DeleteClient(int clientId);
        Task<Client> FindClientAsync(int id);
        Task<IList<Client>> GetClientsAsync();
    }
}
