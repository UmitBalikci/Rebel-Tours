using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RebelTours.Management.Application.Cities;
using RebelTours.Management.Application.Stations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RebelTours.Management.Presentation.Controllers
{
    public class StationController : Controller
    {
        private readonly IStationService _stationService;
        private readonly ICityService _cityService;

        public StationController(IStationService stationService, ICityService cityService)
        {
            _stationService = stationService;
            _cityService = cityService;
        }
        public IActionResult Index()
        {
            var cities = _cityService.GetAll();
            var stations = _stationService.GetAll();
            ViewBag.CityList = cities;
            return View(stations);
        }

        public IActionResult GetById(StationDTO stationDTO)
        {
            var station = _stationService.GetById(stationDTO.Id);
            return View(station);
        }
        public IActionResult Create()
        {
            var cities = _cityService.GetAll();
            ViewBag.CityList = new SelectList(cities, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(StationDTO stationDTO)
        {
            _stationService.Create(stationDTO);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var station = _stationService.GetById(id);
            var cities = _cityService.GetAll();
            ViewBag.CityList = new SelectList(cities, "Id", "Name");
            return View(station);
        }
        [HttpPost]
        public IActionResult Update(StationDTO stationDTO)
        {
            if (stationDTO != null)
            {
                _stationService.Update(stationDTO);
                return RedirectToAction("Index");
            }
            return Content("Hatalı işlem");
        }
        public IActionResult Delete(StationDTO stationDTO)
        {
            if (stationDTO != null)
            {
                var station = _stationService.GetById(stationDTO.Id);
                _stationService.Delete(station);
                return RedirectToAction("Index");
            }
            return Content("Silinecek kayıt bulunamadı..");
        }
    }
}
