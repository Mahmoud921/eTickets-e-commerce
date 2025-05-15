using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorController : Controller
    {
        //Services
        private readonly IActorService _service;
        public ActorController(IActorService service)
        {
            _service = service;
        }


        // Index ===> Home of Actors
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Actor/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //Post: Actor/Create
        [HttpPost]
        public async Task<IActionResult> Create(Actor actor) 
        {
            if (ModelState.IsValid) {
                await _service.InsertAsync(actor);
                return RedirectToAction("Index");
            }
            return View(actor);
        }

        //Get: Actor/Details/id
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var actor = await _service.GetByIdAsync(id);
            if (actor == null) return View("NotFound");
            return View(actor);
        }


        // Get: Actor/Edit/id

        public async Task<IActionResult> Edit(int id)
        {
            var actor = await _service.GetByIdAsync(id);
            if (actor == null) return View("NotFound");
            return View(actor);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, Actor newActor)
        {
            if (!ModelState.IsValid) return View(newActor);
            await _service.UpdateAsync(id, newActor);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id) {
            var actor = await _service.GetByIdAsync(id);
            if (actor == null) return View("NotFound");
            return View(actor);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actor = await _service.GetByIdAsync(id);
            if (actor == null) return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
