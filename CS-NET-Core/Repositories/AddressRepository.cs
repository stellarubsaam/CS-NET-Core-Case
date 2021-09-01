using CS_NET_Core.Domain;
using CS_NET_Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_NET_Core.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly AddressContext _context;
        public AddressRepository(AddressContext context)
        {
            _context = context;
        }

        public async Task<Address> Create(Address address)
        {
            _context.Addresses.Add(address);
            await _context.SaveChangesAsync();

            return address; 
        }

        public async Task Delete(int id)
        {
            var addressToDelete = await _context.Addresses.FindAsync(id);
            _context.Addresses.Remove(addressToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Address>> Get(GetAllAddressesFilter filter = null)
        {
            var queryable = _context.Addresses.AsQueryable();

            queryable = AddFiltersOnQuery(filter, queryable);

            return await queryable.ToListAsync();
        }

        public async Task<Address> Get(int id)
        {
            return await _context.Addresses.FindAsync(id);
        }

        public async Task Update(Address address)
        {
            _context.Entry(address).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        private static IQueryable<Address> AddFiltersOnQuery(GetAllAddressesFilter filter, IQueryable<Address> queryable)
        {
            if(filter.Street != null || filter.StreetNumber != null || filter.PostalCode != null || filter.Town != null || filter.Country != null)
            {
                queryable = queryable.Where(x => x.Street == filter.Street || x.StreetNumber == filter.StreetNumber || x.PostalCode == filter.PostalCode || x.Town == filter.Town || x.Country == filter.Country);
            }
            return queryable;
        }
    }
}
