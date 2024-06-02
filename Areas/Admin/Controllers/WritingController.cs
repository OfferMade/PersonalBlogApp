using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace PersonalBlogApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WritingController : Controller
    {
        private readonly IServiceManager _manager;

        public WritingController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var model = _manager.WritingService.GetAllWritings(false);
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] Writing writing)
        {
            if(ModelState.IsValid) {
                _manager.WritingService.CreateWriting(writing);
                return RedirectToAction("Index");
            }
            return View();  
        }

        public IActionResult Update([FromRoute(Name ="id")] int id)
        {
            var model = _manager.WritingService.GetOneWriting(id, false);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Writing writing)
        {
            if (ModelState.IsValid) {
                _manager.WritingService.UpdateOneWriting(writing);
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Delete([FromRoute(Name ="id")]int id)
        {
            _manager.WritingService.DeleteOneWriting(id);
            return RedirectToAction("Index");
        }
    }
}
