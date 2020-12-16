using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WADLab9.Models;
using WADLab9.Services.Customers;
using WADLab9.Services.Orders;

namespace WADLab9.Controllers
{
    public class OrderController : Controller
    {
        private OrderService service;
        private CustomerService _service;
        public OrderController(OrderService service, CustomerService _service)
        {
            this.service = service;
            this._service = _service;
        }
        public IActionResult Index()
        {

            return View(service.GetOrder());
        }
        public IActionResult Create()
        {
            ViewBag.cusData = new SelectList(_service.GetCustomers(),"customerid","customername");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Order order)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    service.addOrder(order);
                    return RedirectToAction("index");
                }
            }
            catch (Exception e)
            {
                ViewBag.Msg = e.Message;

                throw;
            }
            return View();
        }
    }
}
