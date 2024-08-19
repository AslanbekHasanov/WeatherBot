using Telegram.Bot.Types;
using Telegram.Bot;

namespace WeatherBot.API.Services.Foundation
{
    public partial class WeatherBotService
    {
        async Task ToshkentCityCommand(ITelegramBotClient client, Update update)
        {
            if (update.Message?.Text is "Toshkent sh 🏙")
            {
                var getInfoTashkent =
                    await this.weatherBotBroker.GetWeatherInfo(latitude: 41.3089348, longtidue: 69.270655);

                var menuMurkup = MenuMurkap();

                string path = "../../../Assets/Images/toshkent-city.png";
                using (var stream = new FileStream(path, FileMode.Open))
                {
                    await client.SendPhotoAsync(
                    chatId: update.Message.Chat.Id,
                    photo: InputFileStream.FromStream(stream),
                    replyMarkup: menuMurkup,
                    caption: $"Country name: {getInfoTashkent.city.name}\n" +
                    $"Description: {getInfoTashkent.list[0].weather[0].description}\n" +
                    $"Gradus: {getInfoTashkent.list[0].main.temperature} °C\n" +
                    $"Humidity: {getInfoTashkent.list[0].main.humidity} %\n" +
                    $"Speed: {getInfoTashkent.list[0].wind.speed} km/h\n"
                    );
                }

                return;
            }
        }
    }
}
