using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;



namespace Bakery.Controllers
{
    public class VenderController : Controller
    {

        [HttpGet("/vendor")]
        public ActionResult Index()
        {
            List<Vendor> allVendor = Vendor.GetAll();
            return View(allVendor);
        }

        [HttpGet("/vendor/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendor")]
        public ActionResult Create(string name, string description)
        {
            Vendor myItem = new Vendor(name, description);
            return RedirectToAction("Index");
        }

        // [HttpPost("/vendor/{Id}/order/new")]
        // public ActionResult Create(string description, string date, int price, string title)
        // {
        //   Order myOrder = new Order (description, date, price, title);
        //   return View(myOrder);
        // }

        // [HttpGet("/vendor/{orderId}/order/{orderId}")]
        // public ActionResult Create(string order)
        // {
            
        //     List<Order> addOrder= Vendor.AddOrder(order);
            
           
           
        //     return View(addOrder);
        // }
    }
}