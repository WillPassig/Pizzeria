using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizzeria.Data.Contexts;
using Pizzeria.Data.Features.Customers;
using Pizzeria.Domain.Features.Customers;
using Pizzeria.Domain.Tests.Base;
using System.Data.Entity;

namespace Pizzeria.Data.Tests.Features.Customers
{
    [TestClass]
    public class CustomerSQLRepositoryTests
    {
        private CustomerSQLRepository _customerRepository;
        private PizzeriaContext _context;

        [TestInitialize]
        public void TestSetUp()
        {
            _context = new PizzeriaContext("PizzeriaTests");
            _customerRepository = new CustomerSQLRepository(_context);

            Database.SetInitializer(new SQLTestsSetUp());

            _context.Database.Initialize(true);
        }

        [TestMethod]
        public void GetAllCustomers()
        {
            int customersPreRegisteredBySQLTestsSetUp = 1;

            IEnumerable<Customer> customersFound = new List<Customer>();

            customersFound = _customerRepository.GetAll();

            customersFound.Count().Should().Be(customersPreRegisteredBySQLTestsSetUp);
        }
    }
}
