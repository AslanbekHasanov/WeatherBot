using WeatherBot.API.Services.Foundation;

IWeatherBotService weatherBot = new  WeatherBotService();
weatherBot.StartBot();
Console.WriteLine("Bot ishlayapti.");
Console.ReadKey();