using Microsoft.AspNetCore.Mvc;

namespace PersonalBlogApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
