using Microsoft.AspNetCore.Mvc;

namespace PersonalBlogApp.Areas.Admin.Controllers
{
    public class WritingController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
