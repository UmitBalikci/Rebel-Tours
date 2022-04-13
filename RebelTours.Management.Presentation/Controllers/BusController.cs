using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RebelTours.Management.Application.Buses;
using RebelTours.Management.Application.BusModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RebelTours.Management.Presentation.Controllers
{
    public class BusController : Controller
    {
        private readonly IBusService _busService;
        private readonly IBusModelService _busModelService;

        public BusController(IBusService busService, IBusModelService busModelService)
        {
            _busService = busService;
            _busModelService = busModelService;
        }
        public IActionResult Index()
        {
            var busModels = _busModelService.GetAll();
            var buses = _busService.GetAll();
            ViewBag.BusModels = busModels;
            return View(buses);
        }
        public IActionResult GetById(int id)
        {
            var busModels = _busModelService.GetById(id);
            var bus =_busService.GetById(id);
            ViewBag.BusModels = busModels;
            if (bus != null)
            {
                return View(bus);
            }
            return Content("Bu Id'ye ait kayıt bulunamadı");
        }
        public IActionResult Create()
        {
            var busModels = _busModelService.GetAll();
            ViewBag.BusModels = new SelectList(busModels, "Id", "Name");
            return View();

        }
        [HttpPost]
        public IActionResult Create(BusDTO busDTO)
        {
            _busService.Create(busDTO);
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            var bus = _busService.GetById(id);
            if (bus != null)
            {
                
                return View(bus);
            }
            return Content("Bu Id'ye ait kayıt bulunamadı");
        }
        [HttpPost]
        public IActionResult Update(BusDTO busDTO)
        {
            _busService.Update(busDTO);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(BusDTO busDTO)
        {
            var deletedItem = _busService.GetById(busDTO.Id);
            if (deletedItem != null)
            {
                _busService.Delete(deletedItem);
                return RedirectToAction("Index");
            }
            return Content("Bu id'ye ait kayıt bulunamadı");

        }
    }
}
