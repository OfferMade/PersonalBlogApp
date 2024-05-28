using Microsoft.AspNetCore.Mvc;

namespace PersonalBlogApp.Controllers
{
    public class BlogController : Controller{
        public IActionResult Index(){
            return View();
        }
    }
}