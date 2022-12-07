using AutoMapper;
using CleanArchTDC.Application.ViewModels;
using CleanArchTDC.Domain.Entities;

namespace CleanArchTDC.Application.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Customer, CustomerViewModel>();
        }
    }
}
