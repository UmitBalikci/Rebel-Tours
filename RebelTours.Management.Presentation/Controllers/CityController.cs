using Microsoft.AspNetCore.Mvc;
using RebelTours.Management.Application;
using RebelTours.Management.Application.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace RebelTours.Management.Presentation.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }
        public IActionResult Index()
        {
            var cities = _cityService.GetAll();
            return View(cities);
        }
        public IActionResult GetById(int id)
        {
            var city = _cityService.GetById(id);
            if (city != null)
            {
                return View(city);
            }
            else
            {
                return Content("kayıt bulunamadı");
            }
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CityDTO city)
        {

            var result = _cityService.Create(city);
            if (result.IsSucceeded)
            {
                //ViewBag.CommandResult = result;
                //TempData["CommanResult"] = result;
                //TempData["message"] = "bravoo";
                string data = JsonSerializer.Serialize(result);
                TempData["message"] = data;
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.CommandResult = result;
                return View();
            }
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var city = _cityService.GetById(id);
            return View(city);
        }

        [HttpPost]
        public IActionResult Update(CityDTO city)
        {
            if (city != null)
            {
                _cityService.Update(city);

                return RedirectToAction("Index");
                //return View(city);
            }
            return Content("Hatalı işlem");
        }
        //public IActionResult Delete(int id)
        //{
        //    var city = _cityService.GetById(id);
        //    return RedirectToAction("Index");
        //}

        public IActionResult Delete(CityDTO cityDTO)
        {
            if (cityDTO != null)
            {
                var city = _cityService.GetById(cityDTO.Id);
                _cityService.Delete(city);
                return RedirectToAction("Index");
            }
            return Content("Silinecek kayıt bulunamadı");
        }
    }
}
