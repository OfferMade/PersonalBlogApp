﻿using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;

namespace PersonalBlogApp.Controllers
{
    public class CategoryController : Controller
    {
        private IRepositoryManager _manager;

        public CategoryController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Category> Index()
        {
            return _manager.Category.FindAll(false);
        }
    }
        
}
