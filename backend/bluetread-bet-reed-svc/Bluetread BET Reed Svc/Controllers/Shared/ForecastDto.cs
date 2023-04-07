public class LocationDto
{
    public string Name { get; set; }
    public string Region { get; set; }
    public string Country { get; set; }
    public float Lat { get; set; }
    public float Lon { get; set; }
    public string TzId { get; set; }
    public long LocaltimeEpoch { get; set; }
    public string Localtime { get; set; }
}

public class ConditionDto
{
    public string Text { get; set; }
    public string Icon { get; set; }
    public int Code { get; set; }
}

public class CurrentDto
{
    public long LastUpdatedEpoch { get; set; }
    public string LastUpdated { get; set; }
    public float TempC { get; set; }
    public float TempF { get; set; }
    public int IsDay { get; set; }
    public ConditionDto Condition { get; set; }
    public float WindMph { get; set; }
    public float WindKph { get; set; }
    public int WindDegree { get; set; }
    public string WindDir { get; set; }
    public float PressureMb { get; set; }
    public float PressureIn { get; set; }
    public float PrecipMm { get; set; }
    public float PrecipIn { get; set; }
    public int Humidity { get; set; }
    public int Cloud { get; set; }
    public float FeelslikeC { get; set; }
    public float FeelslikeF { get; set; }
    public float VisKm { get; set; }
    public float VisMiles { get; set; }
    public float Uv { get; set; }
    public float GustMph { get; set; }
    public float GustKph { get; set; }
}

public class DayDto
{
    public float MaxtempC { get; set; }
    public float maxtemp_f { get; set; }
    public float mintemp_C { get; set; }
    public float mintemp_f { get; set; }
    public float avgtemp_c { get; set; }
    public float avgtemp_f { get; set; } 

    public ConditionDto Condition { get; set; }
    public float Uv { get; set; }
}

public class ForecastdayDto
{
    public string Date { get; set; }
    public long DateEpoch { get; set; }
    public DayDto Day { get; set; }
}

public class ForecastDto
{
    public List<ForecastdayDto> Forecastday { get; set; }
}

public class WeatherDto
{
    public LocationDto Location { get; set; }
    public CurrentDto Current { get; set; }
    public ForecastDto Forecast { get; set; }
}


