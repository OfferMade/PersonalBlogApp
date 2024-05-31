using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalBlogApp.Models;
using Repositories;
using Repositories.Contracts;
using Services.Contracts;

namespace PersonalBlogApp.Controllers
{
    public class BlogController : Controller
    {
        private readonly IServiceManager _manager;

        public BlogController(IServiceManager manager)
        {
            _manager = manager;
        }



        //DependencyInjection


        public IActionResult Index()
        {
            var model = _manager.WritingService.GetAllWritings(false);
            return View(model);
        }

        public IActionResult Get([FromRoute(Name ="id")] int id)
        {
            var model = _manager.WritingService.GetOneWriting(id,false);
            return View(model);
        }
    }
}