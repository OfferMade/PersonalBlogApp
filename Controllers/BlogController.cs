using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalBlogApp.Models;
using Repositories;
using Repositories.Contracts;

namespace PersonalBlogApp.Controllers
{
    public class BlogController : Controller
    {
        private readonly IRepositoryManager _manager;

        public BlogController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        //DependencyInjection
       

        public IActionResult Index()
        {
            var model = _manager.Writing.GetAllWritings(false);
            return View(model);
        }

        public IActionResult Get(int id)
        {
            var model = _manager.Writing.GetOneWriting(id,false);
            return View(model);
        }
    }
}