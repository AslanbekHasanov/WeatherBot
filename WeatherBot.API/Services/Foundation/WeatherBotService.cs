using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using WeatherBot.API.Brokers.TelegramBot;
using WeatherBot.API.Brokers.Weathers;
using WeatherBot.API.Models.Weathers;

namespace WeatherBot.API.Services.Foundation
{
    public partial class WeatherBotService: IWeatherBotService
    {
        private readonly IWeatherBotBroker weatherBotBroker;
        private readonly ITelegramBotBroker telegramBotBroker;

        public WeatherBotService()
        {
            this.weatherBotBroker = new WeatherBotBroker();
            this.telegramBotBroker = new TelegramBotBroker();
        }

        public void StartBot()
        {
            this.telegramBotBroker.StartTelegramBot(HandleUpdate, HandleError);
        }

        private async Task HandleUpdate(ITelegramBotClient client, Update update, CancellationToken token)
        {
            try
            {
                if(update.Message?.Type is MessageType.Text)
                {

                    if (update.Message.Text is "/start")
                    {
                        var menuMurkap = MenuMurkap();

                        await client.SendTextMessageAsync(
                            chatId: update.Message.Chat.Id,
                            replyMarkup: menuMurkap,
                            text: "Welcome to, My Weather Bot\n\nPlace choose button👇");
                    }

                    //for Tashkent
                    await ToshkentCityCommand(client, update);
                }
            }
            catch (Exception ex)
            {

                await client.SendTextMessageAsync(
                    chatId: 7252396202,
                    text: "Error!");
            }

            
        }
        private async Task HandleError(ITelegramBotClient client, Exception exception, CancellationToken token)
        {
            await client.SendTextMessageAsync(
                chatId: 7252396202,
                text: "Error!");
        }
    }
}
