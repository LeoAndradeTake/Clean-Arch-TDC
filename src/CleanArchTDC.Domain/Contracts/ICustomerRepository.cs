using CleanArchTDC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchTDC.Domain.Contracts
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer> GetById(Guid? id);

        void Add(Customer customer);
        void Update(Customer customer);
        void Remove(Customer customer);
    }
}
