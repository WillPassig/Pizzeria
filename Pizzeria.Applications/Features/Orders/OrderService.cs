using Pizzeria.Domain.Features.Orders;
using Pizzeria.Domain.Interfaces.Orders;
using System.Collections.Generic;

namespace Pizzeria.Applications.Features.Orders
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public long Add(Order order)
        {
            return _orderRepository.Add(order);
        }

        public void Delete(Order order)
        {
            _orderRepository.Delete(order);
        }

        public void Update()
        {
            _orderRepository.Update();
        }

        public IEnumerable<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }
    }
}
