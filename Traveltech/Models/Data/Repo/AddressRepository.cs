using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Models.Data.Repo
{
    public class AddressRepository : IAddressRepository
    {
        private readonly DataContext dc;

        public AddressRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void AddAddress(Address address)
        {
            dc.Addresses.Add(address);
        }

        public void DeleteAddress(int addressId)
        {
            var id = dc.Addresses.Find(addressId);
            dc.Addresses.Remove(id);
        }


        public async Task<Address> FindAddressAsync(int id)
        {
            return await dc.Addresses.FindAsync(id);
        }

        public async Task<IList<Address>> GetAddressesAsync()
        {
            return await dc.Addresses.ToListAsync();
        }
    }
    public interface IAddressRepository
    {
        void AddAddress(Address address);
        void DeleteAddress(int addressId);
        Task<Address> FindAddressAsync(int id);
        Task<IList<Address>> GetAddressesAsync();
    }
}
