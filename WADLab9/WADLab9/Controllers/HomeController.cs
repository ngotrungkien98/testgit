using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WADLab9.Models;



using WADLab9.Services.CustomerOrders;



namespace WADLab9.Controllers
{
    public class HomeController : Controller
    {

        private CustomerOrderService service;
        public HomeController(CustomerOrderService service)
        {
            this.service = service;
        }





/*
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
*/
        public IActionResult Index()
        {

            return View(service.GetCustomerOrders());
        }
















        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
