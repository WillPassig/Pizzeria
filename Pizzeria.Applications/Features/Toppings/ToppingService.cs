using Pizzeria.Domain.Features.Toppings;
using Pizzeria.Domain.Interfaces.Toppings;
using System.Collections.Generic;

namespace Pizzeria.Applications.Features.Toppings
{
    public class ToppingService : IToppingService
    {
        private IToppingRepository _toppingRepository;

        public ToppingService(IToppingRepository toppingRepository)
        {
            _toppingRepository = toppingRepository;
        }

        public long Add(Topping topping)
        {
            return _toppingRepository.Add(topping);
        }

        public void Delete(Topping topping)
        {
            _toppingRepository.Delete(topping);
        }

        public void Update()
        {
            _toppingRepository.Update();
        }

        public IEnumerable<Topping> GetAll()
        {
            return _toppingRepository.GetAll();
        }
    }
}
