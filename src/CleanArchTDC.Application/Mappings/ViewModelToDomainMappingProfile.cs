using AutoMapper;
using CleanArchTDC.Application.ViewModels;
using CleanArchTDC.Domain.Entities;

namespace CleanArchTDC.Application.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CustomerViewModel, Customer>();
        }
    }
}
