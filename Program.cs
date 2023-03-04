using System;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using System.IO;
using Telegram.Bot.Types.InputFiles;


namespace TelegramBot
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionPool connect = new ConnectionPool();
            var Bot = connect.returnBot();
            Bot.StartReceiving(Update, Error);
            Console.WriteLine("Бот запущен");
            Console.ReadLine(); 
        }
        
        async static Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }
        async static Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {
            var message = update.Message;
            if (message.Text != null)
            {
                Console.WriteLine($"Получено сообщение от {message.Chat.Username} {message.Chat.FirstName} : {message.Text} ");
                switch (message.Text)
                {
                    case "/start": 
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "👋Привет , с помощью данного бота ты можешь узнать расписание занятий , звонков и тд , все кнопки для управления ботом снизу", ParseMode.MarkdownV2, replyMarkup: Menu.returnFirstMenu(), cancellationToken: token);
                        break;
                    //Главное меню
                    case "🕒Расписание звонков":
                        await botClient.SendPhotoAsync(
                        chatId: message.Chat.Id,
                        photo: ("https://user-images.githubusercontent.com/125977820/220346306-ac5512e0-cff5-4e82-92cc-e3b110ebec8a.jpg"), caption:"<b>Press F</b>" , parseMode: ParseMode.Html, cancellationToken: token);
                        break;

                    case "📅Расписание занятий":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Выбери свой курс : ", ParseMode.MarkdownV2, replyMarkup: Menu.returnSecondMenu(), cancellationToken: token);
                        break;

					case "🌐Где находиться наш колледж ?":
						await botClient.SendVenueAsync(chatId: message.Chat.Id, latitude: 52.290614 , longitude: 76.958973 , title:"Колледж информационных технологий" , address : "Г.Павлодар , Ул.Лермонтова 93 ",cancellationToken: token);
						break;
                    case "❓О Боте":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Выбери что тебя интересует : ", ParseMode.MarkdownV2, replyMarkup: Menu.returnFirstMenu(), cancellationToken: token);
                        break;
                    //Курсы
                    case "Первый":
						await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Выбери свою группу : ", ParseMode.MarkdownV2, replyMarkup: Menu.return1kyrsMenu(), cancellationToken: token);
						break;

					case "Второй":
						await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Выбери свою группу : ", ParseMode.MarkdownV2, replyMarkup: Menu.return2kyrsMenu(), cancellationToken: token);
						break;

					case "Третий":
						await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Выбери свою группу : ", ParseMode.MarkdownV2, replyMarkup: Menu.return3kyrsMenu(), cancellationToken: token);
						break;

					case "Четвёртый":
						await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Выбери свою группу : ", ParseMode.MarkdownV2, replyMarkup: Menu.return4kyrsMenu(), cancellationToken: token);
						break;

					case "⬅Назад":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Вы вернулись в главное меню ", ParseMode.MarkdownV2, replyMarkup: Menu.returnFirstMenu(), cancellationToken: token);
                        break;

                    //Группы
                    case "ИС-120":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Вы вернулись в главное меню ", ParseMode.MarkdownV2, replyMarkup: Menu.return1kyrsMenu(), cancellationToken: token);
                        break;
                    case "ИС-220":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Вы вернулись в главное меню ", ParseMode.MarkdownV2, replyMarkup: Menu.return2kyrsMenu(), cancellationToken: token);
                        break;
                    case "ИС-320":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Выбери день недели", ParseMode.MarkdownV2, replyMarkup: Menu.Dennedeli(), cancellationToken: token);
                        break;
                    case "ИС-420":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Вы вернулись в главное меню ", ParseMode.MarkdownV2, replyMarkup: Menu.returnFirstMenu(), cancellationToken: token);
                        break;
                    case "ВТ-180":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Вы вернулись в главное меню ", ParseMode.MarkdownV2, replyMarkup: Menu.return1kyrsMenu(), cancellationToken: token);
                        break;
                    case "ВТ-280":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Вы вернулись в главное меню ", ParseMode.MarkdownV2, replyMarkup: Menu.return2kyrsMenu(), cancellationToken: token);
                        break;
                    case "ВТ-380":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Вы вернулись в главное меню ", ParseMode.MarkdownV2, replyMarkup: Menu.return3kyrsMenu(), cancellationToken: token);
                        break;
                    case "ВТ-480":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Вы вернулись в главное меню ", ParseMode.MarkdownV2, replyMarkup: Menu.returnFirstMenu(), cancellationToken: token);
                        break;
                    case "АЖ-180":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Вы вернулись в главное меню ", ParseMode.MarkdownV2, replyMarkup: Menu.return1kyrsMenu(), cancellationToken: token);
                        break;
                    case "АЖ-280":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Вы вернулись в главное меню ", ParseMode.MarkdownV2, replyMarkup: Menu.return2kyrsMenu(), cancellationToken: token);
                        break;
                    case "АЖ-380":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Вы вернулись в главное меню ", ParseMode.MarkdownV2, replyMarkup: Menu.return3kyrsMenu(), cancellationToken: token);
                        break;
                    case "АЖ-480":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Вы вернулись в главное меню ", ParseMode.MarkdownV2, replyMarkup: Menu.returnFirstMenu(), cancellationToken: token);
                        break;
                    case "⬅⬅Назад":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Вы вернулись назад ", ParseMode.MarkdownV2, replyMarkup: Menu.returnSecondMenu(), cancellationToken: token);
                        break;

                    //Дни недели
                    case "Понедельник":
                        await botClient.SendPhotoAsync(chatId: message.Chat.Id, photo: "https://user-images.githubusercontent.com/125977820/220633839-f2f2a254-a240-4817-a5cd-4a22a600728d.png", parseMode: ParseMode.Html, replyMarkup: Menu.Dennedeli(), cancellationToken: token);
                        break;
                    case "Вторник":
                        await botClient.SendPhotoAsync(chatId: message.Chat.Id, photo: "https://user-images.githubusercontent.com/125977820/220635286-e954ccc9-761e-4f48-984e-fbcb9789d9cf.png", parseMode: ParseMode.Html, replyMarkup: Menu.Dennedeli(), cancellationToken: token);
                        break;
                    case "Среда":
                        await botClient.SendPhotoAsync(chatId: message.Chat.Id, photo: "https://user-images.githubusercontent.com/125977820/220635787-28325d39-f5a8-4763-a5bc-f3be377ed963.png", parseMode: ParseMode.Html, replyMarkup: Menu.Dennedeli(), cancellationToken: token);
                        break;
                    case "Четверг":
                        await botClient.SendPhotoAsync(chatId: message.Chat.Id, photo: "https://user-images.githubusercontent.com/125977820/220636073-fb972e07-45ab-4dd8-917b-4a91a504e8cd.png", parseMode: ParseMode.Html, replyMarkup: Menu.Dennedeli(), cancellationToken: token);
                        break;
                    case "Пятница":
                        await botClient.SendPhotoAsync(chatId: message.Chat.Id, photo: "https://user-images.githubusercontent.com/125977820/220636229-d95e82ff-d898-483b-9196-765fd46054d1.png", parseMode: ParseMode.Html, replyMarkup: Menu.Dennedeli(), cancellationToken: token);
                        break;
                    case "⬅⬅⬅Назад":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Вы вернулись назад ", ParseMode.MarkdownV2, replyMarkup: Menu.return3kyrsMenu(), cancellationToken: token);
                        break;

                }
            }
        }
    }
}