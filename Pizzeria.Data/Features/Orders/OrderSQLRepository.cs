using Pizzeria.Data.Contexts;
using Pizzeria.Domain.Features.Orders;
using Pizzeria.Domain.Interfaces.Orders;
using System.Collections.Generic;
using System.Linq;

namespace Pizzeria.Data.Features.Orders
{
    public class OrderSQLRepository : IOrderRepository
    {
        PizzeriaContext _context;

        public OrderSQLRepository(PizzeriaContext context)
        {
            _context = context;
        }

        public long Add(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();

            return order.ID;
        }

        public void Delete(Order order)
        {
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.ToList();
        }

        public void Update()
        {
            _context.SaveChanges();
        }
    }
}
