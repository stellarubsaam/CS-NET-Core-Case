using CS_NET_Core.Models;
using CS_NET_Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using CS_NET_Core.Queries;
using CS_NET_Core.Domain;
using AutoMapper;

namespace CS_NET_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressRepository _addressRepository;
        public AddressContext _context;
        public IMapper _mapper;

        public AddressController(IAddressRepository addressRepository, AddressContext context, IMapper mapper)
        {
            this._addressRepository = addressRepository;
            this._context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<Address>> GetAddresses([FromQuery] GetAllAddressesQuery query)
        {
            var filter = _mapper.Map<GetAllAddressesFilter>(query);
            return await _addressRepository.Get(filter);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Address>> GetAddresses(int id)
        {
            return await _addressRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Address>> PostAddresses([FromBody] Address address)
        {
            var newAddress = await _addressRepository.Create(address);
            return CreatedAtAction(nameof(GetAddresses), new { id = newAddress.Id }, newAddress);
        }

        [HttpPut]
        public async Task<ActionResult> PutBooks(int id, [FromBody] Address address)
        {
            if(id != address.Id)
            {
                return BadRequest();
            }

            await _addressRepository.Update(address);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete (int id)
        {
            var addressToDelete = await _addressRepository.Get(id);
            if(addressToDelete == null)
            {
                return NotFound();
            }

            await _addressRepository.Delete(addressToDelete.Id);
            return NoContent();
        }
    }
}
