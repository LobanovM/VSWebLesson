using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ch05_JqGrid.Controllers
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

        public string GetData()
        {
            return @"<rows>
                      <row>
                        <cell>0</cell>
                        <cell>Авто</cell>
                        <cell>0</cell>
                        <cell></cell>
                        <cell>false</cell>
                        <cell>false</cell>
                      </row>
                      <row>
                        <cell>1</cell>
                        <cell>Honda</cell>
                        <cell>1</cell>
                        <cell>0</cell>
                        <cell>false</cell>
                        <cell>false</cell>
                      </row>
                      <row>
                        <cell>2</cell>
                        <cell>Civic</cell>
                        <cell>2</cell>
                        <cell>1</cell>
                        <cell>true</cell>
                        <cell>true</cell>
                      </row>
                      <row>
                        <cell>3</cell>
                        <cell>Cr-v</cell>
                        <cell>2</cell>
                        <cell>1</cell>
                        <cell>true</cell>
                        <cell>true</cell>
                      </row>
                      <row>
                        <cell>4</cell>
                        <cell>Hummer</cell>
                        <cell>1</cell>
                        <cell>0</cell>
                        <cell>false</cell>
                        <cell>false</cell>
                      </row>
                      <row>
                        <cell>5</cell>
                        <cell>H2</cell>
                        <cell>2</cell>
                        <cell>4</cell>
                        <cell>true</cell>
                        <cell>true</cell>
                      </row>
                      <row>
                        <cell>6</cell>
                        <cell>Lada</cell>
                        <cell>1</cell>
                        <cell>0</cell>
                        <cell>true</cell>
                        <cell>false</cell>
                      </row>
                    </rows>";
        }
    }
}