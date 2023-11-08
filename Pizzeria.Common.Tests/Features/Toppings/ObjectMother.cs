using Pizzeria.Domain.Features.Toppings;
using System.Collections.Generic;

namespace Pizzeria.Common.Tests
{
    public static partial class ObjectMother
    {
        public static Topping GetPepperoniTopping()
        {
            Topping pepperoni = new Topping();
            pepperoni.Name = "Pepperoni";
            pepperoni.BasePrice = 10;

            return pepperoni;
        }

        public static List<Topping> GetPepperoniToppingList()
        {
            return new List<Topping>() { ObjectMother.GetPepperoniTopping() };
        }

        public static Topping GetCheddarTopping()
        {
            Topping cheddar = new Topping();
            cheddar.Name = "Cheddar";
            cheddar.BasePrice = 8;

            return cheddar;
        }

        public static List<Topping> GetCheddarToppingList()
        {
            return new List<Topping>() { ObjectMother.GetCheddarTopping() };
        }

        public static Topping GetTomatoTopping()
        {
            Topping tomato = new Topping();
            tomato.Name = "Tomato";
            tomato.BasePrice = 6;

            return tomato;
        }

        public static List<Topping> GetChickenToppingList()
        {
            return new List<Topping>() { ObjectMother.GetTomatoTopping() };
        }

        public static List<Topping> GetPepperoniCheddarTomatoToppingList()
        {
            return new List<Topping>() { ObjectMother.GetPepperoniTopping(), ObjectMother.GetCheddarTopping(), ObjectMother.GetTomatoTopping() };
        }
    }
}
