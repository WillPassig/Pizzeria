using Pizzeria.Domain.Base;
using Pizzeria.Domain.Features.Customers;
using Pizzeria.Domain.Features.Pizzas;
using System;
using System.Collections.Generic;

namespace Pizzeria.Domain.Features.Orders
{
    public class Order : Entity
    {
        public DateTime Date { get; set; }

        public Customer Customer { get; set; }

        public List<Pizza> Pizzas { get; set; }

        public double TotalPrice { get; set; }

        public Order(DateTime date, Customer customer, List<Pizza> pizzas)
        {
            Date = date;
            Customer = customer;
            Pizzas = pizzas;
            TotalPrice = 0;
            foreach (Pizza pizza in pizzas)
            {
                TotalPrice += pizza.Price;
            }
        }
    }
}
