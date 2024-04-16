using Microsoft.AspNetCore.Mvc;
using MVC_2.Models;

namespace MVC_2.Controllers
{
    public class BrandController:Controller
    {
		private List<Brand> _brands;

		public BrandController()
        {
			_brands = new List<Brand>
		{
			new Brand { Id = 1, Name = "Brand 1",Description =" hfdjljfsk"},
			new Brand { Id = 2, Name = "Brand 2",Description =" gftsgsf"},
			new Brand { Id = 3, Name = "Brand 3", Description = " hfdjiukuykiuljfsk"}
		};
		}
        public ActionResult Index()
		{
			if (_brands == null || _brands.Count == 0)
			{
				TempData["ErrorMessage"] = "Brand not found";
				return RedirectToAction("error");
			}

			ViewBag.Brands = _brands;

			return View();
		}

        public ActionResult Details(int id)
        {
            var brand = _brands.Find(x => x.Id == id);
            if (brand == null)
            {
                TempData["ErrorMessage"] = "This brand doesnt exist !";
                return RedirectToAction("error");
            }

            ViewData["brand"] = brand;

            return View();
        }

        public ViewResult Error()
        {
            return View();
        }
    }
}
