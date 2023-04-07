using Bluetread_BET_Reed_Svc.Controllers.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using static System.Net.WebRequestMethods;

namespace Bluetread_BET_Reed_Svc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public HttpClient httpClient;


        //Without a doubt needs to be in appsettings
        private string apiKey = "ad2c6666121b455fbcf03114230704";


        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            httpClient = new HttpClient();
        }



        [HttpPost(Name = "GetWeatherForecast")]
        public async Task<GetForecastOutputDto> GetForecast(GetForecastInputDto input)
        {
            var output = new GetForecastOutputDto();

            var requestString = 
                "https://api.weatherapi.com/v1/forecast.json?key=" + apiKey  + 
                "&q=" + input.City +  
                "&days=" + input.Days + 
                "&aqi=no";


            var forecastRes = await httpClient.GetFromJsonAsync<WeatherDto>(requestString);

            output.Weather = forecastRes;
            output.CreatedAt = DateTime.UtcNow;

            return output;
        }
    }
}