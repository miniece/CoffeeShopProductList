using CoffeeShopProductList.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopProductList.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
