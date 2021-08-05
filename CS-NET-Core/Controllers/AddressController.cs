using CS_NET_Core.Models;
using CS_NET_Core.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_NET_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressRepository _addressRepository;

        public AddressController(IAddressRepository addressRepository)
        {
            this._addressRepository = addressRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Address>> GetAddresses()
        {
            //return await _addressRepository.Get();
            return await _addressRepository.Get();
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
