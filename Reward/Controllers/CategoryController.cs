using Microsoft.AspNetCore.Mvc;

namespace Reward.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
