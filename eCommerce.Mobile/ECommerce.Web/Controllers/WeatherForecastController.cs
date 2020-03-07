using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ECommerce.Web.Controllers
{
    [Produces("application/json")]
    [ApiController]
    //[Route("api/products")]
    public class WeatherForecastController : ControllerBase
    {
        //Array of string
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        //Contructor
        public WeatherForecastController()
        {
        
        }

        //CRUD
        //HttpGet / HttpPost / HttpUpdate / HttpDelete
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        // localhost/weatherforecast/SaveCategory/{Id}/{CatName}
        [HttpPost]
        public int SaveCategory(int id,string CatName)
        {
            //gawa ni hacker SQL INJECTION
            CatName = "DROP DATABASE";
            
            string sql_query = "INSERT INTO Category...blah..blah" + CatName;
            return 1;
        }

        [HttpPut]
        public int UpdateCategory()
        {
            return 1;
        }

        [HttpDelete]
        public int DeleteCategory()
        {
            return 1;
        }
    }
}
