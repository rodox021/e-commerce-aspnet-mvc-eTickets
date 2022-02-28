using eTickets.Models;
using eTickets.Services;
using eTickets.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        public readonly IActorsService _actorsService;

        public ActorsController(IActorsService actorsService)
        {
            _actorsService = actorsService;
        }

        public async Task<IActionResult> Index()
        {
            var actors = await _actorsService.GetAll();
            return View(actors);
        }
        public IActionResult Create(Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            _actorsService.Add(actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
