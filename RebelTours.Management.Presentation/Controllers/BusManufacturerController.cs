using Microsoft.AspNetCore.Mvc;
using RebelTours.Management.Application.BusManufacturers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RebelTours.Management.Presentation.Controllers
{
    public class BusManufacturerController : Controller
    {
        private readonly IBusManufacturerService _busManufacturerService;

        public BusManufacturerController(IBusManufacturerService busManufacturerService)
        {
            _busManufacturerService = busManufacturerService;
        }

        public IActionResult Index()
        {
            var busManufacturer = _busManufacturerService.GetAll();
            return View(busManufacturer);
        }

        public IActionResult GetById(int id)
        {
            var busManufacturer = _busManufacturerService.GetById(id);
            if (busManufacturer != null)
            {
                return View(busManufacturer);
            }
            else
            {
                return Content("Bu Id' ye sahip değer bulunmadı!");
            }
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BusManufacturerDTO busManufacturerDTO)
        {
            if (busManufacturerDTO.Name != null)
            {
                _busManufacturerService.Create(busManufacturerDTO);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorMessage = "Name Alanı boş olamaz!";
                return View();
            }
        }
        public IActionResult Update(int id)
        {
            var busManufacturer = _busManufacturerService.GetById(id);      

            return View(busManufacturer);
        }
        [HttpPost]
        public IActionResult Update(BusManufacturerDTO busManufacturerDTO)
        {
            if (busManufacturerDTO != null)
            {
                _busManufacturerService.Update(busManufacturerDTO);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorMessage = "Name Alanı Boş Olamaz!";
                return View();
            }
        }
        public IActionResult Delete(BusManufacturerDTO busManufacturerDTO)
        {
            _busManufacturerService.Delete(busManufacturerDTO);
            return RedirectToAction("Index");
        }
    }
}
