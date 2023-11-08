using Pizzeria.Domain.Features.Addresses;
using Pizzeria.Domain.Features.Customers;

namespace Pizzeria.Common.Tests
{
    public static partial class ObjectMother
    {
        public static Customer GetCustomer_JohnDoe()
        {
            Address address = new Address();
            address.Street = "Broadway";
            address.AdditionalInfo = "First building";
            address.City = "New York";
            address.PostalCode = "123456";

            string name = "John Doe";

            string phoneNumber = "5551234";

            Customer customer = new Customer();
            customer.Address = address;
            customer.Name = name;
            customer.PhoneNumber = phoneNumber;

            return customer;
        }
    }
}
