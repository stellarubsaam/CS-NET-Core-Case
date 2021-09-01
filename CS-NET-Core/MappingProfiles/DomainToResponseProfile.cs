using AutoMapper;
using CS_NET_Core.Domain;
using CS_NET_Core.Queries;

namespace CS_NET_Core.MappingProfiles
{
    public class DomainToResponseProfile : Profile
    {
        public DomainToResponseProfile()
        {
            CreateMap<GetAllAddressesQuery, GetAllAddressesFilter>();
        }
    }
}
