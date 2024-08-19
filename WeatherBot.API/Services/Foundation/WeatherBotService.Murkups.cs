using Telegram.Bot.Types.ReplyMarkups;

namespace WeatherBot.API.Services.Foundation
{
    public partial class WeatherBotService
    {

        private static IReplyMarkup? MenuMurkap()
        {
            return new ReplyKeyboardMarkup
            (
                new KeyboardButton[][]
                {
                    new KeyboardButton[]
                    {
                        new KeyboardButton("Toshkent sh 🏙"),
                        new KeyboardButton("🏙  Toshkent sh")
                    },
                    new KeyboardButton[]
                    {
                        new KeyboardButton("🏙  Toshkent sh"),
                        new KeyboardButton("🏙  Toshkent sh")
                    },
                    new KeyboardButton[]
                    {
                        new KeyboardButton("🏙  Toshkent sh"),
                        new KeyboardButton("🏙  Toshkent sh")
                    },
                    new KeyboardButton[]
                    {
                        new KeyboardButton("🏙  Toshkent sh")
                    }
                }
            )
            {
                ResizeKeyboard = true
            };
        }
    }
}
