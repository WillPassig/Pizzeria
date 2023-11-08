using Pizzeria.Domain.Base;
using Pizzeria.Domain.Features.Addresses;

namespace Pizzeria.Domain.Features.Customers
{
    public class Customer : Entity
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public Address Address { get; set; }
    }
}
