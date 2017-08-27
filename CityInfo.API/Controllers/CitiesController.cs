using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [Route("API/Cities")]
    public class CitiesController:Controller
    {
        [HttpGet()]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var temp = CitiesDataStore.Current.Cities.Where(c => c.ID == id).FirstOrDefault();
            if (temp == null)
            {
                return NotFound();
            } else
            {
                return Ok(temp);
            }

        }
    }
}
