using AutoMapper;
using PatikaHomework.DataModel;

namespace PatikaHomework.MapProfile
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<CustomerDto, CustomerDtoResponse>().ReverseMap();
            CreateMap<Customer, CustomerDtoResponse>().ReverseMap();
        }
    }
}
