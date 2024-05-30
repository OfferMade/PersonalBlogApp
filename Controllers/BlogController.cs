using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalBlogApp.Models;

namespace PersonalBlogApp.Controllers
{
    public class BlogController : Controller
    {
        private readonly RepositoryContext _context;
                                                        //DependencyInjection
        public BlogController(RepositoryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Writings.ToList();
            return View(model);
        }

        public IActionResult Get(int id)
        {
            Writing writing = _context.Writings.FirstOrDefault(p=>p.WritingId.Equals(id));
            return View(writing);
        }
    }
}