using AjaxDropDownList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxDropDownList.Controllers
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

        public ActionResult AjaxList(ViewModel model)
        {
            return View();
        }

        public PartialViewResult LoadItems()
        {
            return PartialView();
        }

        [HttpPost]
        public JsonResult CountryList()
        {
            // normally, you pass a list obtained from ORM or ADO.NET DataTable or DataReader
            return Json(new Dictionary<string, string>() { { "PH", "Philippines" }, { "CN", "China" }, { "CA", "Canada" }, { "JP", "Japan" } }.ToList());
        }
    }
}