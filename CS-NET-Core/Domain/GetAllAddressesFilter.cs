namespace CS_NET_Core.Domain
{
    public class GetAllAddressesFilter
    {
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string PostalCode { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }
    }
}
