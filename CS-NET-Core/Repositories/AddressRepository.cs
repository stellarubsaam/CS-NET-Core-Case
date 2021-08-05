﻿using CS_NET_Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
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

        public async Task<IEnumerable<Address>> Get()
        {
            return await _context.Addresses.ToListAsync();
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
    }
}
