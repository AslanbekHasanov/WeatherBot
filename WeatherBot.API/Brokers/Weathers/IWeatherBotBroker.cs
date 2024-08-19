using WeatherBot.API.Models.Weathers;

namespace WeatherBot.API.Brokers.Weathers
{
    internal interface IWeatherBotBroker
    {
        Task<Root> GetWeatherInfo(double latitude, double longtidue);
    }
}
