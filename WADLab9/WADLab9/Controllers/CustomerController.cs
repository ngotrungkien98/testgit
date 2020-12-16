using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WADLab9.Models;
using WADLab9.Services.Customers;

namespace WADLab9.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerService service;
        public CustomerController(CustomerService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            ViewBag.cusList = service.GetCustomers();
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customer) 
        {

            try
            {
                if (ModelState.IsValid)
                {
                    service.addCustomer(customer);
                    return RedirectToAction("index");
                }
            }
            catch (Exception e)
            {
                ViewBag.Msg = e.Message;
            }
            return View();
         }
            
    }
}
