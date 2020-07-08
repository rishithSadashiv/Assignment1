using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class ProductController : Controller
    {

        public static List<Product> list = new List<Product>
        {
            new Product(){ pid=0001,pname="Laptop", price=50000.0,stock=5},
            new Product() { pid=0002,pname="Phone", price=10000.50, stock=10}
        };



        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product p)
        {
            list.Add(p);
            return RedirectToAction("Index");
        }
    }
}
