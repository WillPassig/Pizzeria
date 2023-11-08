using Pizzeria.Domain.Features.Orders;
using Pizzeria.Domain.Features.Pizzas;
using System;
using System.Collections.Generic;

namespace Pizzeria.Common.Tests
{
    public static partial class ObjectMother
    {
        public static Order GetSmallPepperoniPizzaForJohnDoe()
        {
            return new Order(DateTime.Now, ObjectMother.GetCustomer_JohnDoe(), new List<Pizza>() { ObjectMother.GetSmallPepperoniPizza() });
        }
    }
}
