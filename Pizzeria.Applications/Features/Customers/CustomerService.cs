using Pizzeria.Domain.Features.Customers;
using Pizzeria.Domain.Interfaces.Customers;
using System.Collections.Generic;

namespace Pizzeria.Applications.Features.Customers
{
    public class CustomerService : ICustomerService
    {
        ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public long Add(Customer customer)
        {
            return _customerRepository.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customerRepository.Delete(customer);
        }

        public void Update()
        {
            _customerRepository.Update();
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }
    }
}
