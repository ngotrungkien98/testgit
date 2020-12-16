using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WADLab9.Models;

namespace WADLab9.Services.Orders
{
    public interface OrderService
    {
        List<Order> GetOrder();
        void addOrder(Order order);
    }
}
