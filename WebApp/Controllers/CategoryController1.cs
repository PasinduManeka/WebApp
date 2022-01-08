using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class CategoryController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
