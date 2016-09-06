using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSiteMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ListarProductos()
        {
            Data.NorthwindEntities1 context = new Data.NorthwindEntities1();
            List<WebSiteMVC.Models.Product> productos = context.Products.ToList();

            return View(productos);
        }

        public ActionResult ListarEmpleados()
        {
            Data.NorthwindEntities1 context = new Data.NorthwindEntities1();
            List<WebSiteMVC.Models.Employee> empleados = context.Employees.ToList();

            return View(empleados);

        }

        public ActionResult ListarCategoria()
        {
            Data.NorthwindEntities1 context = new Data.NorthwindEntities1();
            List<WebSiteMVC.Models.Category> categoria = context.Categories.ToList();

            return View(categoria);
        }
    }
}
