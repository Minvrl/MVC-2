using Microsoft.AspNetCore.Mvc;
using MVC_2.Models;

namespace MVC_2.Controllers
{
    public class ProductController:Controller
    {
        private List<Product> _products;
        public ProductController()
        {
            _products = new List<Product>
        {
            new Product { Id = 1, Name = "Pr 1", Price = 250 },
            new Product { Id = 2, Name = "Pr 2", Price = 450 },
            new Product { Id = 3, Name = "Pr 3", Price = 550 }
        };
        }

        public ActionResult Index()
        {
            if (_products == null || _products.Count == 0)
            {
                TempData["ErrorMessage"] = "Product not found";
                return RedirectToAction("error");
            }

            ViewBag.Products = _products;

            return View();
        }

        public ActionResult Details(int id)
        {
            var product = _products.Find(x => x.Id == id);
            if (product == null)
            {
                TempData["ErrorMessage"] = "Product not found by given id";
                return RedirectToAction("error");
            }
            ViewData["product"] = product;



            return View();
        }

        public ViewResult Error()
        {
            return View();

        }
    }
}
