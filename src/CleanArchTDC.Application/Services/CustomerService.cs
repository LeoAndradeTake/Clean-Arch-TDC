using AutoMapper;
using CleanArchTDC.Application.Contracts;
using CleanArchTDC.Application.ViewModels;
using CleanArchTDC.Domain.Contracts;
using CleanArchTDC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchTDC.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public void Add(CustomerViewModel customerViewModel)
        {
            var mappedCustomer = _mapper.Map<Customer>(customerViewModel);
            _customerRepository.Add(mappedCustomer);
        }

        public async Task<CustomerViewModel> GetById(Guid? id)
        {
            var customer = await _customerRepository.GetById(id);
            return _mapper.Map<CustomerViewModel>(customer);
        }

        public async Task<IEnumerable<CustomerViewModel>> GetCustomers()
        {
            var customers = await _customerRepository.GetCustomers();
            return _mapper.Map<IEnumerable<CustomerViewModel>>(customers);
        }

        public void Remove(Guid? id)
        {
            var customer = _customerRepository.GetById(id).Result;
            _customerRepository.Remove(customer);
        }

        public void Update(CustomerViewModel customerViewModel)
        {
            var mappedCustomer = _mapper.Map<Customer>(customerViewModel);
            _customerRepository.Update(mappedCustomer);
        }
    }
}
