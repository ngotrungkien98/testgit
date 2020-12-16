using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WADLab9.Models;

using WADLab9.Repository;
using WADLab9.Models;

namespace WADLab9.Services.Customers
{
    public class CustomerServiceImpl : CustomerService
    {
        private SaleContext context;
        public CustomerServiceImpl(SaleContext context)
        {
            this.context = context;
        }
        public void addCustomer(Customer customer)
        {
            context.Customer.Add(customer);
            context.SaveChanges();
        }

        public List<Customer> GetCustomers()
        {
            return context.Customer.ToList();

        }
    }
}
