﻿using eBilety.Data.Services;
using eBilety.Data.Static;
using eBilety.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eBilety.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;

        public ProducersController(IProducersService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAll();
            return View(allProducers);
        }

        //GET: producers/details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetById(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        //GET: producers/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Avatar,FullName,Bio")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);

            await _service.Add(producer);
            return RedirectToAction(nameof(Index));
        }

        //GET: producers/edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetById(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Avatar,FullName,Bio")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);

            if (id == producer.Id)
            {
                await _service.Update(id, producer);
                return RedirectToAction(nameof(Index));
            }
            return View(producer);
        }

        //GET: producers/delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _service.GetById(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerDetails = await _service.GetById(id);
            if (producerDetails == null) return View("NotFound");

            await _service.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
