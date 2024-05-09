using bulkyWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Reward.Models;

namespace Reward.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController( ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            //var ObjCategoryList = _db.Categories.ToList();             we can write it also
            List<Category> ObjCategoryList = _db.Categories.ToList();
            return View(ObjCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create( Category obj)
        {
            _db.Categories.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
