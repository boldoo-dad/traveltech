using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traveltech.Models.Widgets;

namespace Traveltech.Models.Data.Repo
{
    public class ContactRepository : IContactRepository
    {
        private readonly DataContext dc;

        public ContactRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void AddContact(Contact contact)
        {
            dc.Contacts.Add(contact);
        }

        public void DeleteContact(int contactId)
        {
            var id = dc.Contacts.Find(contactId);
            dc.Contacts.Remove(id);
        }

        public async Task<Contact> FindContactAsync(int id)
        {
            return await dc.Contacts
                 .Include(m => m.Addresses)
                 .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IList<Contact>> GetContactsAsync()
        {
            return await dc.Contacts
                  .Include(m => m.Addresses)
                  .ToListAsync();
        }
    }
    public interface IContactRepository
    {
        void AddContact(Contact contact);
        void DeleteContact(int contactId);
        Task<Contact> FindContactAsync(int id);
        Task<IList<Contact>> GetContactsAsync();
    }
}
