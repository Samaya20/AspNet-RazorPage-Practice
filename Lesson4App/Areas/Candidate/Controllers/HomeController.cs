using Microsoft.AspNetCore.Mvc;

namespace Lesson4App.Areas.Candidate.Controllers
{
    [Area("Candidate")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
