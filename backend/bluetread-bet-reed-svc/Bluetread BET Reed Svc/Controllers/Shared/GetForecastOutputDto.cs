namespace Bluetread_BET_Reed_Svc.Controllers.Shared
{
    public class GetForecastOutputDto
    {
        public WeatherDto Weather { get; set; }   
        public DateTime CreatedAt { get; set; }
    }
}
