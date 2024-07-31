using Lesson4App.Data;
using Lesson4App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson4App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductDbContext _context;

        public HomeController(ProductDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products
                .Select(p => new ProductViewModel { Name = p.Name, Price = p.Price });
            var categories = _context.Categories
                .Select(c => new CategoryViewModel { Title = c.Title });
            
            var vm = new ProductCategoryListViewModel
            {
                Categories = categories,
                Products = products
            };
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
