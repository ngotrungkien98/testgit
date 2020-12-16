using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WADLab9.Models;

namespace WADLab9.Services.Customers
{
    public interface CustomerService
    {
        List<Customer> GetCustomers();
        void addCustomer(Customer customer);
    }
}
