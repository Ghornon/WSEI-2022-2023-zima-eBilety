﻿using eBilety.Data.Services;
using eBilety.Models;
using Microsoft.AspNetCore.Mvc;

namespace eBilety.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            this._service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if(!ModelState.IsValid)
                return View(actor);

            _service.Add(actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
