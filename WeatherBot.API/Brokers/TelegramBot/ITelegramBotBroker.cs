using Telegram.Bot;
using Telegram.Bot.Types;

namespace WeatherBot.API.Brokers.TelegramBot
{
    public interface ITelegramBotBroker
    {
        void StartTelegramBot(
            Func<ITelegramBotClient, Update, CancellationToken, Task> handleUpdate,
            Func<ITelegramBotClient, Exception, CancellationToken, Task> handleError
            );
    }
}
