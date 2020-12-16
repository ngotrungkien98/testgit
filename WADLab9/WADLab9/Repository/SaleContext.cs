using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WADLab9.Models;

namespace WADLab9.Repository
{
    public class SaleContext : DbContext
    {
        public SaleContext(DbContextOptions options) : base(options) { }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<CustomerOrder> CustomerOrder { get; set; }
    }
}
