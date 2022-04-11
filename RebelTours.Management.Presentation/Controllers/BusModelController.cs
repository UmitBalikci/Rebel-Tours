using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RebelTours.Management.Application.BusManufacturers;
using RebelTours.Management.Application.BusModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RebelTours.Management.Presentation.Controllers
{
    public class BusModelController : Controller
    {
        private readonly IBusModelService _busModelService;
        private readonly IBusManufacturerService _busManufacturerService;

        public BusModelController(IBusModelService busModelService, IBusManufacturerService busManufacturerService)
        {
            _busModelService = busModelService;
            _busManufacturerService = busManufacturerService;
        }
        public IActionResult Index()
        {
            var busManufacturers = _busManufacturerService.GetAll();
            var busModels = _busModelService.GetAll();
            ViewBag.BusManufacturers = busManufacturers;
            return View(busModels);
        }
        public IActionResult GetById(int id)
        {
            var busManufacurer = _busManufacturerService.GetById(id);
            var busModel = _busModelService.GetById(id);
            if (busModel != null)
            {
                ViewBag.BusManufacturer = busManufacurer;
                return View(busModel);
            }
            else
            {
                return Content("Bu Id'ye sahip kayıt bulunamadı!");
            }
        }
        public IActionResult Create()
        {
            var busManufacturers = _busManufacturerService.GetAll();
            ViewBag.BusManufacturerList = new SelectList(busManufacturers, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(BusModelDTO busModelDTO)
        {
            if (busModelDTO != null)
            {
                _busModelService.Create(busModelDTO);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorMessage = "Alanlar boş olamaz";
                return View();
            }
        }
        public IActionResult Update(int id)
        {
            var busModel = _busModelService.GetById(id);
            var busManufacturers = _busManufacturerService.GetAll();
            ViewBag.BusManufacturerList = new SelectList(busManufacturers, "Id", "Name");
            return View(busModel);
        }
        [HttpPost]
        public IActionResult Update(BusModelDTO busModelDTO)
        {
            _busModelService.Update(busModelDTO);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(BusModelDTO busModelDTO)
        {
            var deletedBusModel = _busModelService.GetById(busModelDTO.Id);
            if (deletedBusModel != null)
            {
                _busModelService.Delete(busModelDTO);
                return RedirectToAction("Index");
            }
            else
            {
                return Content("Bu Id' ye sahip kayıt bulunamadı");
            }
        }
    }
}
