using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using WADLab9.Models;
using WADLab9.Repository;
using WADLab9.Services;

using Microsoft.EntityFrameworkCore;
using WADLab9.Services.Customers;
using WADLab9.Services.Orders;
using WADLab9.Services.CustomerOrders;

namespace WADLab9
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            string str = "server = .; database = WADLab9DB ; uid = sa; pwd = 123";
            services.AddDbContext<SaleContext>(options => options.UseSqlServer(str));
            services.AddScoped<CustomerService, CustomerServiceImpl>();
            services.AddScoped<OrderService, OrderServiceImpl>();
            services.AddScoped<CustomerOrderService, CustomerOrderServiceImpl>();


            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
