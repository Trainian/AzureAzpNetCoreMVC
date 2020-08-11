using AzureAspNetCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureAspNetCore.Infrastructure.Interfaces
{
    public interface IOrderService
    {
        public IQueryable<Order> GetAllOrders();

        public IQueryable<Order> GetAllUserOrders(string id);

        public Order GetOrderById(int id);

        public void CreateOrder(Order order);

        public void DeleteOrder(int id);

        public IQueryable<OrderItem> GetAllOrderItems();

        public OrderItem GetOrderItemById(int id);

        public void CreateOrderItem(OrderItem item);

        public void DeleteOrderItem(int id);
    }
}
