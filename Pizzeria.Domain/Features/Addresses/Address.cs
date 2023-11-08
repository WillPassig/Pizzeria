using Pizzeria.Domain.Base;

namespace Pizzeria.Domain.Features.Addresses
{
    public class Address : Entity
    {

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Street { get; set; }

        public string AdditionalInfo { get; set; }

    }

}
