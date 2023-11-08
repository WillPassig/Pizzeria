using Pizzeria.Data.Contexts;
using Pizzeria.Domain.Features.Customers;
using Pizzeria.Domain.Interfaces.Customers;
using System.Collections.Generic;
using System.Linq;

namespace Pizzeria.Data.Features.Customers
{
    public class CustomerSQLRepository : ICustomerRepository
    {
        PizzeriaContext _context;

        public CustomerSQLRepository(PizzeriaContext context)
        {
            _context = context;
        }

        public long Add(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        public void Update()
        {
            _context.SaveChanges();
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public IEnumerable<Customer> SearchCustomerByPhoneNumber(string phoneNumber)
        {
            return _context.Customers.Where(customer => customer.PhoneNumber == phoneNumber).ToList();
        }
    }
}
