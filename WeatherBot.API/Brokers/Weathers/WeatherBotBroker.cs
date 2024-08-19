using Newtonsoft.Json;
using System.Text.Json.Nodes;
using WeatherBot.API.Models.Weathers;

namespace WeatherBot.API.Brokers.Weathers
{
    public class WeatherBotBroker : IWeatherBotBroker
    {
        public async Task<Root> GetWeatherInfo(double latitude, double longtidue)
        {
            var client = new HttpClient();

            var responce = await client.GetStringAsync(
                string.Format($"https://api.openweathermap.org/data/2.5/forecast?lat={latitude}&lon={longtidue}&appid=9eab92acce11e115ff50e74992570cfd"));

            return JsonConvert.DeserializeObject<Root>(responce);
        }
    }
}
