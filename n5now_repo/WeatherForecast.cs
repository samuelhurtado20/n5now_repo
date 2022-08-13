namespace n5now_repo
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}

//https://n5now.notion.site/Sr-7e3d9572e134452b8bd27188dda38e7a