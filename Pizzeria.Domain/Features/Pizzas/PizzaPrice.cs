using System;

namespace Pizzeria.Domain.Features.Pizzas
{
    public static class PizzaPrice
    {
        //Predefined Base Price Values by Size
        static double SmallPizzaBasePrice { get { return 5; } }
        static double MediumPizzaBasePrice { get { return 10; } }
        static double LargePizzaBasePrice { get { return 20; } }

        //Predefined Topping Price Multiplier Values by Size
        static double SmallPizzaToppingPriceMultiplier { get { return 1.0; } }
        static double MediumPizzaToppingPriceMultiplier { get { return 2.0; } }
        static double LargePizzaToppingPriceMultiplier { get { return 4.0; } }

        public static double GetPizzaBasePrice(PizzaSize size)
        {
            switch (size)
            {
                case PizzaSize.SMALL:
                    return SmallPizzaBasePrice;

                case PizzaSize.MEDIUM:
                    return MediumPizzaBasePrice;

                case PizzaSize.LARGE:
                    return LargePizzaBasePrice;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static double GetPizzaToppingPriceMultiplier(PizzaSize size)
        {
            switch (size)
            {
                case PizzaSize.SMALL:
                    return SmallPizzaToppingPriceMultiplier;

                case PizzaSize.MEDIUM:
                    return MediumPizzaToppingPriceMultiplier;

                case PizzaSize.LARGE:
                    return LargePizzaToppingPriceMultiplier;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        
    }
}
