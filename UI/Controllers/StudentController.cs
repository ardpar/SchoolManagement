using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Models;

namespace UI.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly IClubService _clubService;
        
        public StudentController(IStudentService studentService, IClubService clubService)
        {
            _studentService = studentService;
            _clubService = clubService;
        }
        public IActionResult Index()
        {
            

            var student = _studentService.GetAll().Include(x => x.Club).ToList();
            return View(student);
        }

        public IActionResult Create()
        {
            var clubs = _clubService.GetAllAsync().Result.ToList().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
            ViewBag.Clubs = clubs;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            await _studentService.AddAsync(student);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            var clubs = _clubService.GetAllAsync().Result.Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
                
            }).ToList();
            ViewBag.Clubs = clubs;
            var student = await _studentService.GetByIdAsync(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Update(Student student)
        {
            
            _studentService.Update(student);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var student = _studentService.GetByIdAsync(id).Result;
            _studentService.Remove(student);
            return RedirectToAction("Index");
        }
    }
}
