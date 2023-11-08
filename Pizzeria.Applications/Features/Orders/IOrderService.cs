using Pizzeria.Applications.Interfaces;
using Pizzeria.Domain.Features.Orders;

namespace Pizzeria.Applications.Features.Orders
{
    internal interface IOrderService : IService<Order>
    {
    }
}
