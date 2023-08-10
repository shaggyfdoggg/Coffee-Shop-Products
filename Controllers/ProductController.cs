using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop_Product.Model;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop_Product.Controllers
{
    public class ProductController : Controller
    {
        private CoffeedbContext _CoffeedbContext = new CoffeedbContext();

        public IActionResult Details(int id)
        {

            ProductList p = _CoffeedbContext.ProductLists.FirstOrDefault(x => x.Id == id);
            return View(p);
        }

        public IActionResult Index()
        {
            List <ProductList> result = _CoffeedbContext.ProductLists.ToList();

            return View(result);
        }
    }
}