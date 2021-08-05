using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_NET_Core.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string PostalCode { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }
    }
}
