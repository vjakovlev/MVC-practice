using MVC_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Practice.Controllers
{
    public class ProductsController : Controller
    {

        List<Products> ProductList = new List<Products>

        {
            new Products()
            {
                ID = 1,
                Name = "Polo",
                Description = "5 Doors",
                Price = 199
            },

            new Products()
            {
                ID = 2,
                Name = "Golf",
                Description = "5 Doors",
                Price = 299
            },

            new Products()
            {
                ID = 3,
                Name = "Passat",
                Description = "5 Doors",
                Price = 499
            },

            new Products()
            {
                ID = 4,
                Name = "Jetta",
                Description = "3 Doors",
                Price = 399
            },

            new Products()
            {
                ID = 5,
                Name = "PassatCC",
                Description = "3 Doors",
                Price = 699
            },

            new Products()
            {
                ID = 6,
                Name = "Touareg",
                Description = "5 Doors",
                Price = 1399
            },

            new Products()
            {
                ID = 6,
                Name = "Buba",
                Description = "3 Doors",
                Price = 899
            }
        };

        public ActionResult Index()
        {
            ViewBag.ProductList = ProductList;

            return View();
        }

        public ActionResult ShowAllCars()
        {
            ViewBag.ProductList = ProductList;

            return View();
        }

        public ActionResult ShowCarDetails(int? id)
        {

            if (id == null)
            {
                return View();
            }

            ViewBag.Product = ProductList.First(x => x.ID == id);

            return View();
        }
    }
}
