using Pizzeria.Domain.Features.Customers;
using System.Collections.Generic;

namespace Pizzeria.Domain.Interfaces.Customers
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> SearchCustomerByPhoneNumber(string phoneNumber);
    }
}
