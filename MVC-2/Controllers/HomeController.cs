using Microsoft.AspNetCore.Mvc;
using MVC_2.Models;

namespace MVC_2.Controllers
{
    public class HomeController:Controller
    {
        private List<Product> _products;
        private List<Brand> _brands;
        public HomeController()
        {
            _products = new List<Product>
        {
            new Product { Id = 1, Name = "Pr 1", Price = 250 },
            new Product { Id = 2, Name = "Pr 2", Price = 450 },
            new Product { Id = 3, Name = "Pr 3", Price = 550 }
        };
            _brands = new List<Brand>
        {
            new Brand { Id = 1, Name = "Brand 1",Description =" hfdjljfsk"},
            new Brand { Id = 2, Name = "Brand 2",Description =" hfdjljfsk"},
            new Brand { Id = 3, Name = "Brand 3", Description = " hfdjljfsk"}
        };
        }
        public ActionResult Index()
        {
            ViewBag.Products = _products;   
            ViewBag.Brands = _brands;

            return View();
        }

      
    }
}
