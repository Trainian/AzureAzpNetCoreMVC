using AzureAspNetCore.DAL.Context;
using AzureAspNetCore.Domain.Entities;
using AzureAspNetCore.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureAspNetCore.Infrastructure.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly AzureAspNetCoreContext _context;

        public OrderService(AzureAspNetCoreContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Добавить Заказ
        /// </summary>
        /// <param name="order">Заказ</param>
        public void CreateOrder(Order order)
        {
            _context.Orders.Add(order);
        }

        /// <summary>
        /// Добавить Товар
        /// </summary>
        /// <param name="item">Товар</param>
        public void CreateOrderItem(OrderItem item)
        {
            _context.OrderItems.Add(item);
        }

        /// <summary>
        /// Удалить Заказ
        /// </summary>
        /// <param name="id">ИД Заказа</param>
        public void DeleteOrder(int id)
        {
            var order = GetOrderById(id);
            _context.Orders.Remove(order);
        }

        /// <summary>
        /// Удалить Товар
        /// </summary>
        /// <param name="id">ИД Товара</param>
        public void DeleteOrderItem(int id)
        {
            var orderItem = GetOrderItemById(id);
            _context.OrderItems.Remove(orderItem);
        }

        /// <summary>
        /// Получить все Заказы Товаров
        /// </summary>
        /// <returns>Список Заказанных Товаров</returns>
        public IQueryable<OrderItem> GetAllOrderItems()
        {
            return _context.OrderItems.ToList().AsQueryable();
        }

        /// <summary>
        /// Получить все Заказы
        /// </summary>
        /// <returns>Список Заказов</returns>
        public IQueryable<Order> GetAllOrders()
        {
            return _context.Orders.ToList().AsQueryable();
        }

        /// <summary>
        /// Получить все Заказы пользователя
        /// </summary>
        /// <param name="id">ИД Пользователя</param>
        /// <returns>Список Заказов</returns>
        public IQueryable<Order> GetAllUserOrders(string id)
        {
            return _context.Orders.Where(x => x.User.Id.Equals(id, StringComparison.CurrentCulture)).AsQueryable();
        }

        /// <summary>
        /// Получить Заказ
        /// </summary>
        /// <param name="id">ИД Заказа</param>
        /// <returns>Заказ</returns>
        public Order GetOrderById(int id)
        {
            return _context.Orders.FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// Получить Заказный Товар
        /// </summary>
        /// <param name="id">ИД Заказанного Товара</param>
        /// <returns>Товар</returns>
        public OrderItem GetOrderItemById(int id)
        {
            return _context.OrderItems.FirstOrDefault(x => x.Id == id);
        }
    }
}
