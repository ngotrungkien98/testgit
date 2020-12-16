using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WADLab9.Models;
using WADLab9.Repository;

namespace WADLab9.Services.Orders 
{
    public class OrderServiceImpl : OrderService
    {
        private SaleContext context;
        public OrderServiceImpl(SaleContext context)
        {
            this.context = context;
        }
        public void addOrder(Order order)
        {
            context.Order.Add(order);
            context.SaveChanges();
        }

        public List<Order> GetOrder()
        {
            return context.Order.ToList();
        }
    }
}
