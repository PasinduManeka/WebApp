using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class CategoryController : Controller
    {
        //object from applicationdbContext
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objList = _db.Category;   
            return View(objList);
        }
    }
}
