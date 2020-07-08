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
            new Product(){ Pid=0001,Pname="Laptop", Price=50000.0,Stock=5},
            new Product() { Pid=0002,Pname="Phone", Price=10000.50, Stock=10}
        };

        public IActionResult Index()
        {
            return View(list);
        }

        //[Route("Create")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product p)
        {
            if(ModelState.IsValid)
            {
                list.Add(p);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create");
            }
            
        }
    }
}
