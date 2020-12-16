using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WADLab9.Services.CustomerOrders
{
    public interface CustomerOrderService
    {
        List<Models.CustomerOrder> GetCustomerOrders();
    }
}
