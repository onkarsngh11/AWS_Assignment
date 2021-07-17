using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NikeWebApp.Database;
using NikeWebApp.Interfaces;
using NikeWebApp.Models;

namespace NikeWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ProductsModel pm = new ProductsModel();
        public IProductDbOps _dbContext;
        public HomeController(ILogger<HomeController> logger,IProductDbOps productDbops)
        {
            _logger = logger;
            _dbContext = productDbops;
        }

        public IActionResult Index()
        {
            IEnumerable<Products> listOfProducts = GetListOfAllProducts();
            pm.ListOfAllProducts = listOfProducts;
            return View(pm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        private IEnumerable<Products> GetListOfAllProducts()
        {
            var list = _dbContext.GetListOfAllProducts();
            return list;
        }
    }
}
