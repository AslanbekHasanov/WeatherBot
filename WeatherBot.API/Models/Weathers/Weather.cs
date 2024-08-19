namespace WeatherBot.API.Models.Weathers
{
    public class Weather
    {
        public int id { get; set; }
        public string fullUrlIco => string.Format("https://openweathermap.org/img/wn/{0}@2x.png", icon);
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }
}
