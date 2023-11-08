using Pizzeria.Applications.Interfaces;
using Pizzeria.Domain.Features.Customers;

namespace Pizzeria.Applications.Features.Customers
{
    internal interface ICustomerService : IService<Customer>
    {
    }
}
