using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());
            return Json(jsonCity);
        }

        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
           _destinationService.TAdd(destination);
            var values = JsonConvert.SerializeObject(destination);
            return Json(values);
        }

        [HttpGet]
        public IActionResult GetById(int DestinationId)
        {
            var values = _destinationService.GetById(DestinationId);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }

  
        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.GetById(id);
            _destinationService.TDelete(values);
            return NoContent();
        }

        [HttpPost]
        public IActionResult UpdateCity(Destination destination)
        {
            _destinationService.TUpdate(destination);
            var result = JsonConvert.SerializeObject(destination);
            return Json(result);
        }





        //public static List<City> Cities = new List<City>()
        //{
        //    new City
        //    {
        //        CityId = 1,
        //        CityName = "Üsküp",
        //        CityCountry = "Makedonya"
        //    },

        //     new City
        //    {
        //        CityId = 2,
        //        CityName = "Roma",
        //        CityCountry = "İtalya"
        //    },

        //      new City
        //    {
        //        CityId = 3,
        //        CityName = "Londra",
        //        CityCountry = "ingiltere"
        //    },
        //};
    }
}
