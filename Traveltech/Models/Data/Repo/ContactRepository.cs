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
        public void addContact(Contact contact)
        {
            dc.Contacts.Add(contact);
        }

        public void deleteContact(int contactId)
        {
            var id = dc.Contacts.Find(contactId);
            dc.Contacts.Remove(id);
        }

        public async Task<Contact> findContactAsync(int id)
        {
            return await dc.Contacts
                 .Include(m => m.Addresses)
                 .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IList<Contact>> getContactsAsync()
        {
            return await dc.Contacts
                  .Include(m => m.Addresses)
                  .ToListAsync();
        }
    }
    public interface IContactRepository
    {
        void addContact(Contact contact);
        void deleteContact(int contactId);
        Task<Contact> findContactAsync(int id);
        Task<IList<Contact>> getContactsAsync();
    }
}
