using Pizzeria.Domain.Features.Toppings;
using System.Collections.Generic;

namespace Pizzeria.Domain.Features.Pizzas
{
    public class Pizza
    {
        public PizzaSize Size { get; set; }

        public List<Topping> Toppings { get; set; }

        public double Price { get; set; }

        public Pizza(List<Topping> toppings, PizzaSize size)
        {
            Toppings = toppings;
            Size = size;
            Price = CalculatePrice(toppings, size);
        }

        public double CalculatePrice(List<Topping> toppings, PizzaSize size)
        {
            Price = PizzaPrice.GetPizzaBasePrice(size);
            double toppingPriceMultiplierBySize = PizzaPrice.GetPizzaToppingPriceMultiplier(size);

            foreach (var topping in toppings)
            {
                Price += topping.BasePrice * toppingPriceMultiplierBySize;
            }

            return Price;
        }
    }
}
