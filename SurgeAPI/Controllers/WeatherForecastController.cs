using Microsoft.AspNetCore.Mvc;
using SurgeAPI.Models;
using SurgeAPI.Repository;

namespace SurgeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICountryRepo countryRepo;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ICountryRepo countryRepo)
        {
            _logger = logger;
            this.countryRepo = countryRepo;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Country> Get()
        {
            var c =  countryRepo.GetCountryList();
            return c.ToArray();
        }
    }
}