using DynamicViewModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicViewModel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View(new Order(){
                Items = new Dictionary<string,Item>()
            });
        }

        [HttpPost]
        public ActionResult Edit(Order order)
        {
            if (ModelState.IsValid)
            {

            }

            return View(order);
        }

        [HttpPost]
        public ActionResult AddItem(String itemName, Int32? itemId)
        {
            Int32 val = itemId ?? default(int);
            return PartialView("OrderItem", new KeyValuePair<String, Item>(
                    Guid.NewGuid().ToString("N"),
                    new Item() { Name = itemName, Id = val }
                ));
        }
    }
}