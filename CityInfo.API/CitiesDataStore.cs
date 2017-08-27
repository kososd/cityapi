using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current {get;} = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto{ ID = 1, Name = "Limerick", Description = "City were I live."},
                new CityDto{ ID = 2, Name = "Dublin", Description = "Capital of Ireland."},
                new CityDto{ ID = 3, Name = "Cork", Description = "City were my kids go to school."},
            };
        }

    }
}
