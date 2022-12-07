using CleanArchTDC.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchTDC.Application.Contracts
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerViewModel>> GetCustomers();
        Task<CustomerViewModel> GetById(Guid? id);

        void Add(CustomerViewModel customerViewModel);
        void Update(CustomerViewModel customerViewModel);
        void Remove(Guid? id);
    }
}
