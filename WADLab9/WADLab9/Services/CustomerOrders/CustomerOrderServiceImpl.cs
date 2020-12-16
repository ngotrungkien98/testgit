using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WADLab9.Models;

using WADLab9.Repository;

namespace WADLab9.Services.CustomerOrders
{
    public class CustomerOrderServiceImpl : CustomerOrderService
    {
        private SaleContext context;
        public CustomerOrderServiceImpl(SaleContext context)
        {
            this.context = context;
        }

        public List<CustomerOrder> GetCustomerOrders()
        {
            return context.CustomerOrder.ToList();
        }
    }
}
