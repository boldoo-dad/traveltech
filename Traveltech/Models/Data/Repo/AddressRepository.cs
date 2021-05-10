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
        public void addAddress(Address address)
        {
            dc.Addresses.Add(address);
        }

        public void deleteAddress(int addressId)
        {
            var id = dc.Addresses.Find(addressId);
            dc.Addresses.Remove(id);
        }


        public async Task<Address> findAddressAsync(int id)
        {
            return await dc.Addresses.FindAsync(id);
        }

        public async Task<IList<Address>> getAddressesAsync()
        {
            return await dc.Addresses.ToListAsync();
        }
    }
    public interface IAddressRepository
    {
        void addAddress(Address address);
        void deleteAddress(int addressId);
        Task<Address> findAddressAsync(int id);
        Task<IList<Address>> getAddressesAsync();
    }
}
