using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Controllers
{
    public class ClubController : Controller
    {
        private readonly IClubService _clubService;
        public ClubController(IClubService clubService)
        {
            _clubService = clubService;
        }
        public async Task<IActionResult> Index()
        {
            var clubs = await _clubService.GetAllAsync();
            return View(clubs);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Club club)
        {
            await _clubService.AddAsync(club);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            var club = await _clubService.GetByIdAsync(id);
            return View(club);
        }

        [HttpPost]
        public IActionResult Update(Club club)
        {
            _clubService.Update(club);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var club = _clubService.GetByIdAsync(id).Result;
            _clubService.Remove(club);
            return RedirectToAction("Index");
        }
    }
}
