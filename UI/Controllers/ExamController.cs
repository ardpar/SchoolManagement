using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Controllers
{
    public class ExamController : Controller
    {
        private readonly IExamService _examService;
        private readonly ICourseService _courseService;
        private readonly IStudentService _studentService;
        public ExamController(IExamService examService, ICourseService courseService, IStudentService studentService)
        {
            _examService = examService;
            _courseService = courseService;
            _studentService = studentService;
        }
        public async Task<IActionResult> Index()
        {
            var exam =  _examService.GetAll().Include(x => x.Student).Include(y => y.Course).ToList();
            return View(exam);
        }

        public IActionResult Create()
        {
            var course = _courseService.GetAllAsync().Result.Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            }).ToList();

            var student = _studentService.GetAllAsync().Result.Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            }).ToList();
            ViewBag.Student = student;
            ViewBag.Course = course;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Exam exam)
        {
            await _examService.AddAsync(exam);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            var course = _courseService.GetAllAsync().Result.Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            }).ToList();

            var student = _studentService.GetAllAsync().Result.Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            }).ToList();
            ViewBag.Student = student;
            ViewBag.Course = course;
            var exam = await _examService.GetByIdAsync(id);
            return View(exam);
        }

        [HttpPost]
        public IActionResult Update(Exam exam)
        {

            _examService.Update(exam);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var exam = _examService.GetByIdAsync(id).Result;
            _examService.Remove(exam);
            return RedirectToAction("Index");
        }


    }
}
