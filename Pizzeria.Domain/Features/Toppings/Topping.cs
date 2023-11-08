using Pizzeria.Domain.Base;

namespace Pizzeria.Domain.Features.Toppings
{
    public class Topping : Entity
    {
        public string Name { get; set; }
        public double BasePrice { get; set; } //This price will be multiplied based on the size of the pizza.
    }
}
