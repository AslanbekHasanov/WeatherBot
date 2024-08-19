using Telegram.Bot;
using Telegram.Bot.Types;

namespace WeatherBot.API.Brokers.TelegramBot
{
 
    public partial class TelegramBotBroker : ITelegramBotBroker
    {
        private readonly string token = @"7252396202:AAEd79QdzHwr2t6vQ8tlehb1Uxu4EwVcBhQ";
        private readonly ITelegramBotClient client;

        public TelegramBotBroker()
        {
            this.client = new TelegramBotClient(token);
        }
    }
}
