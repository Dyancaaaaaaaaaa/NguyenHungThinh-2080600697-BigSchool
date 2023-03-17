using NguyenHungThinh_2080600697.Models;
using NguyenHungThinh_2080600697.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenHungThinh_2080600697.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CourseController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {

                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}