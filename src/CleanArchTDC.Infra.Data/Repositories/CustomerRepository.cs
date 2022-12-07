using CleanArchTDC.Domain.Contracts;
using CleanArchTDC.Domain.Entities;
using CleanArchTDC.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchTDC.Infra.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
        }

        public async Task<Customer> GetById(Guid? id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        public void Remove(Customer customer)
        {
            _context.Remove(customer);
            _context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            _context.Update(customer);
            _context.SaveChanges();
        }
    }
}
