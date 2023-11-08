using Pizzeria.Domain.Features.Pizzas;

namespace Pizzeria.Common.Tests
{
    public static partial class ObjectMother
    {
        public static Pizza GetSmallPepperoniPizza()
        {
            return new Pizza(ObjectMother.GetPepperoniToppingList(), PizzaSize.SMALL);
        }

        public static Pizza GetMediumPepperoniPizza()
        {
            return new Pizza(ObjectMother.GetPepperoniToppingList(), PizzaSize.MEDIUM);
        }

        public static Pizza GetLargePepperoniPizza()
        {
            return new Pizza(ObjectMother.GetPepperoniToppingList(), PizzaSize.LARGE);
        }

        public static Pizza GetSmallPepperoniCheddarTomatoPizza()
        {
            return new Pizza(ObjectMother.GetPepperoniCheddarTomatoToppingList(), PizzaSize.SMALL);
        }

        public static Pizza GetMediumPepperoniCheddarTomatoPizza()
        {
            return new Pizza(ObjectMother.GetPepperoniCheddarTomatoToppingList(), PizzaSize.MEDIUM);
        }

        public static Pizza GetLargePepperoniCheddarTomatoPizza()
        {
            return new Pizza(ObjectMother.GetPepperoniCheddarTomatoToppingList(), PizzaSize.LARGE);
        }

    }
}
