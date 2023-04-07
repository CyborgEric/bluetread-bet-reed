
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http.Results;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bluetread_BET_Reed_Svc.Controllers;
using Bluetread_BET_Reed_Svc.Controllers.Shared;
using Microsoft.Extensions.Logging;
using Xunit;

namespace UnitTests
{
    public class UnitTests
    {
        private readonly ILogger<WeatherForecastController> _logger;

        [Fact]
        public async void ForecastHasCity()
        {        
            var controller = new WeatherForecastController(_logger);

            var input = new GetForecastInputDto();

            input.City = "Tampa";
            input.Days = 14;

            var output = await controller.GetForecast(input);

            bool result = output.Weather.Location.Name.Equals("Tampa");

            Assert.True(result, "City Should Be Tampa");
        }


        [Fact]
        public async void ForecastHasCurrent()
        {
            var controller = new WeatherForecastController(_logger);

            var input = new GetForecastInputDto();

            input.City = "Tampa";
            input.Days = 14;

            var output = await controller.GetForecast(input);

            bool result = output.Weather.Current != null;

            Assert.True(result, "Should Have Current Forecast");
        }
    }
}