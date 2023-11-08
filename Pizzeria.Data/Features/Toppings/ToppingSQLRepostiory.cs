using Pizzeria.Data.Contexts;
using Pizzeria.Domain.Features.Toppings;
using Pizzeria.Domain.Interfaces.Toppings;
using System.Collections.Generic;
using System.Linq;

namespace Pizzeria.Data.Features.Toppings
{
    public class ToppingSQLRepostiory : IToppingRepository
    {

        PizzeriaContext _context;

        public ToppingSQLRepostiory(PizzeriaContext context)
        {
            _context = context;
        }

        public long Add(Topping topping)
        {
            _context.Toppings.Add(topping);
            _context.SaveChanges();

            return topping.ID;
        }

        public IEnumerable<Topping> GetAll()
        {
            return _context.Toppings.ToList();
        }

        public void Update()
        {
            _context.SaveChanges();
        }

        public void Delete(Topping topping)
        {
            _context.Toppings.Remove(topping);
            _context.SaveChanges();
        }
    }
}
