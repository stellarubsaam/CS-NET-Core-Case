using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CS_NET_Core.Models
{
    public class AddressContext : DbContext
    {
        public List<Address> addresses = new List<Address>();

        public AddressContext(DbContextOptions<AddressContext> options)
            :base(options)
        {
            Database.EnsureCreated();
            addresses = Addresses.AsQueryable().ToList();
        }

        public DbSet<Address> Addresses { get; set; }
    }
}
