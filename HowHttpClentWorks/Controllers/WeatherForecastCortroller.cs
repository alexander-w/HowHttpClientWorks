using Microsoft.AspNetCore.Mvc;
using HowHttpClentWorks.Clients;

namespace HowHttpClentWorks.Controllers
{
    [ApiController]
   	[Route("weather")]
    //[Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherClient _weatherClient;

        public WeatherForecastController(IWeatherClient weatherClient)
        {
            _weatherClient = weatherClient;
        }

        [HttpGet("{city}")]
        //[HttpGet]
        public async Task<IActionResult> Get(string city)
        //public async Task<IActionResult> Get([FromQuery] string city)
        {
            if (string.IsNullOrWhiteSpace(city))
                return BadRequest("city is required");

            var result = await _weatherClient.GetCurrentWeatherForCity(city);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
