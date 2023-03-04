using System;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using System.IO;
using Telegram.Bot.Types.InputFiles;

class ConnectionPool
{
    private static string TOKEN = "YOUR_API_TOKEN";
    private TelegramBotClient connect;
    public ConnectionPool()
    {
        this.connect= new TelegramBotClient(TOKEN);
    }
    public TelegramBotClient returnBot() { return this.connect; }
}
