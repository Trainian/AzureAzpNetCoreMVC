using AzureAspNetCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureAspNetCore.Infrastructure.Interfaces
{
    public interface IOrderService
    {
        public IEnumerable<Order> GetAllOrders();

        public IEnumerable<Order> GetAllUserOrders(string id);

        public Order GetOrderById(int id);

        public void CreateOrder(Order order);

        public void DeleteOrder();

        public IEnumerable<OrderItem> GetAllOrderItems();

        public OrderItem GetOrderItem(int id);
    }
}
