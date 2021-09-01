using CS_NET_Core.Domain;
using CS_NET_Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CS_NET_Core.Repositories
{
    public interface IAddressRepository
    {
        Task<IEnumerable<Address>> Get(GetAllAddressesFilter filter = null);
        Task<Address> Get(int id);
        Task<Address> Create(Address address);
        Task Update(Address address);
        Task Delete(int id);
    }
}
