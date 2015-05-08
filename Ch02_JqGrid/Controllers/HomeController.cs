using Ch02_JqGrid.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ch02_JqGrid.Controllers
{
    public class HomeController : Controller
    {
        static List<Book> books = new List<Book>();
        static HomeController()
        {
            books.Add(new Book { Id = 1, Name = "Война и мир", Author = "Л. Толстой", Year = 1863, Price = 220 });
            books.Add(new Book { Id = 2, Name = "Отцы и дети", Author = "И. Тургенев", Year = 1862, Price = 195 });
            books.Add(new Book { Id = 3, Name = "Чайка", Author = "А. Чехов", Year = 1895, Price = 158 });
            books.Add(new Book { Id = 4, Name = "Подросток", Author = "Ф. Достоевский", Year = 1875, Price = 210 });
            books.Add(new Book { Id = 5, Name = "Война и мир", Author = "Л. Толстой", Year = 1863, Price = 220 });
            books.Add(new Book { Id = 6, Name = "Отцы и дети", Author = "И. Тургенев", Year = 1862, Price = 195 });
            books.Add(new Book { Id = 7, Name = "Чайка", Author = "А. Чехов", Year = 1895, Price = 158 });
            books.Add(new Book { Id = 8, Name = "Подросток", Author = "Ф. Достоевский", Year = 1875, Price = 210 });
            books.Add(new Book { Id = 9, Name = "Война и мир", Author = "Л. Толстой", Year = 1863, Price = 220 });
            books.Add(new Book { Id = 10, Name = "Отцы и дети", Author = "И. Тургенев", Year = 1862, Price = 195 });
            books.Add(new Book { Id = 11, Name = "Чайка", Author = "А. Чехов", Year = 1895, Price = 158 });
            books.Add(new Book { Id = 12, Name = "Подросток", Author = "Ф. Достоевский", Year = 1875, Price = 210 });
            books.Add(new Book { Id = 13, Name = "Война и мир", Author = "Л. Толстой", Year = 1863, Price = 220 });
            books.Add(new Book { Id = 14, Name = "Отцы и дети", Author = "И. Тургенев", Year = 1862, Price = 195 });
            books.Add(new Book { Id = 15, Name = "Чайка", Author = "А. Чехов", Year = 1895, Price = 158 });
            books.Add(new Book { Id = 16, Name = "Подросток", Author = "Ф. Достоевский", Year = 1875, Price = 210 });
        }

        public string GetData()
        {
            return JsonConvert.SerializeObject(books);
        }

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
    }
}