using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizzeria.Common.Tests;
using Pizzeria.Domain.Features.Pizzas;

namespace Pizzeria.Domain.Tests.Features.Pizzas
{
    [TestClass]
    public class PizzaTests
    {
        private Pizza _pizza;

        [TestMethod]
        public void PriceOfSmallPizzaWithOneTopping()
        {
            _pizza = ObjectMother.GetSmallPepperoniPizza();

            double pizzaBasePriceBySize = PizzaPrice.GetPizzaBasePrice(PizzaSize.SMALL);
            double pizzaToppingPrice = _pizza.Toppings.First().BasePrice * PizzaPrice.GetPizzaToppingPriceMultiplier(PizzaSize.SMALL);
            double correctPrice = pizzaBasePriceBySize + pizzaToppingPrice;

            _pizza.Price.Should().Be(correctPrice);
        }

        [TestMethod]
        public void PriceOfMediumPizzaWithOneTopping()
        {
            _pizza = ObjectMother.GetMediumPepperoniPizza();

            double pizzaBasePriceBySize = PizzaPrice.GetPizzaBasePrice(PizzaSize.MEDIUM);
            double pizzaToppingPrice = _pizza.Toppings.First().BasePrice * PizzaPrice.GetPizzaToppingPriceMultiplier(PizzaSize.MEDIUM);
            double correctPrice = pizzaBasePriceBySize + pizzaToppingPrice;

            _pizza.Price.Should().Be(correctPrice);
        }

        [TestMethod]
        public void PriceOfLargePizzaWithOneTopping()
        {
            _pizza = ObjectMother.GetLargePepperoniPizza();

            double pizzaBasePriceBySize = PizzaPrice.GetPizzaBasePrice(PizzaSize.LARGE);
            double pizzaToppingPrice = _pizza.Toppings.First().BasePrice * PizzaPrice.GetPizzaToppingPriceMultiplier(PizzaSize.LARGE);
            double correctPrice = pizzaBasePriceBySize + pizzaToppingPrice;

            _pizza.Price.Should().Be(correctPrice);
        }

        [TestMethod]
        public void PriceOfSmallPizzaWithMultipleToppings()
        {
            _pizza = ObjectMother.GetSmallPepperoniCheddarTomatoPizza();

            double pizzaBasePriceBySize = PizzaPrice.GetPizzaBasePrice(PizzaSize.SMALL);
            double pizzaToppingsPriceMultiplierBySize = PizzaPrice.GetPizzaToppingPriceMultiplier(PizzaSize.SMALL);
            double pizzaToppingsPrice = 0;

            foreach (var topping in _pizza.Toppings)
            {
                pizzaToppingsPrice += topping.BasePrice * pizzaToppingsPriceMultiplierBySize;
            }

            double correctPrice = pizzaBasePriceBySize + pizzaToppingsPrice;
            _pizza.Price.Should().Be(correctPrice);
        }

        [TestMethod]
        public void PriceOfMediumPizzaWithMultipleToppings()
        {
            _pizza = ObjectMother.GetMediumPepperoniCheddarTomatoPizza();

            double pizzaBasePriceBySize = PizzaPrice.GetPizzaBasePrice(PizzaSize.MEDIUM);
            double pizzaToppingsPriceMultiplierBySize = PizzaPrice.GetPizzaToppingPriceMultiplier(PizzaSize.MEDIUM);
            double pizzaToppingsPrice = 0;

            foreach (var topping in _pizza.Toppings)
            {
                pizzaToppingsPrice += topping.BasePrice * pizzaToppingsPriceMultiplierBySize;
            }

            double correctPrice = pizzaBasePriceBySize + pizzaToppingsPrice;
            _pizza.Price.Should().Be(correctPrice);
        }

        [TestMethod]
        public void PriceOfLargePizzaWithMultipleToppings()
        {
            _pizza = ObjectMother.GetLargePepperoniCheddarTomatoPizza();

            double pizzaBasePriceBySize = PizzaPrice.GetPizzaBasePrice(PizzaSize.LARGE);
            double pizzaToppingsPriceMultiplierBySize = PizzaPrice.GetPizzaToppingPriceMultiplier(PizzaSize.LARGE);
            double pizzaToppingsPrice = 0;

            foreach (var topping in _pizza.Toppings)
            {
                pizzaToppingsPrice += topping.BasePrice * pizzaToppingsPriceMultiplierBySize;
            }

            double correctPrice = pizzaBasePriceBySize + pizzaToppingsPrice;
            _pizza.Price.Should().Be(correctPrice);
        }
    }
}
