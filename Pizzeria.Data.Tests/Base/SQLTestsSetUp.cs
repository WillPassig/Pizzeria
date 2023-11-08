using Pizzeria.Common.Tests;
using Pizzeria.Data.Contexts;
using Pizzeria.Domain.Features.Customers;
using Pizzeria.Domain.Features.Orders;
using Pizzeria.Domain.Features.Pizzas;
using Pizzeria.Domain.Features.Toppings;
using System.Data.Entity;

namespace Pizzeria.Domain.Tests.Base
{
    public class SQLTestsSetUp : DropCreateDatabaseAlways<PizzeriaContext>
    {
        protected override void Seed(PizzeriaContext context)
        {
            Customer customer = ObjectMother.GetCustomer_JohnDoe();
            context.Customers.Add(customer);

            Topping cheddarTopping = ObjectMother.GetCheddarTopping();
            context.Toppings.Add(cheddarTopping);
            Topping pepperoniTopping = ObjectMother.GetPepperoniTopping();
            context.Toppings.Add(pepperoniTopping);
            Topping tomatoTopping = ObjectMother.GetTomatoTopping();
            context.Toppings.Add(tomatoTopping);

            Pizza smallPepperoniPizza = ObjectMother.GetSmallPepperoniPizza();

            Order order = new Order(DateTime.Now, customer, new List<Pizza>() { smallPepperoniPizza });
            context.Orders.Add(order);

            base.Seed(context);
        }
    }
}
