using Microsoft.AspNetCore.Mvc;

namespace PersonalBlogApp.Controllers
{
    public class PortfolyoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}