using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public async Task< IActionResult> Index()
        {
            var course = await _courseService.GetAllAsync();
            return View(course);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Course course)
        {
            await _courseService.AddAsync(course);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            var course = await _courseService.GetByIdAsync(id);
            return View(course);
        }

        [HttpPost]
        public IActionResult Update(Course course)
        {
            _courseService.Update(course);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var course = _courseService.GetByIdAsync(id).Result;
            _courseService.Remove(course);
            return RedirectToAction("Index");
        }


    }
}
