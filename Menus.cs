using System;
using Telegram.Bot.Types.ReplyMarkups;

public static class Menu
{

	private static ReplyKeyboardMarkup replyKeyboardMarkup;
	
	public static ReplyKeyboardMarkup returnFirstMenu() {
        replyKeyboardMarkup = new ReplyKeyboardMarkup(new[] {
            new KeyboardButton[] { "🕒Расписание звонков" },
            new KeyboardButton[] { "📅Расписание занятий" },
            new KeyboardButton[] { "🌐Где находиться наш колледж ?" },
            new KeyboardButton[] { "❓О Боте" },
        })
        {
            ResizeKeyboard = true
        };

        return replyKeyboardMarkup;
	}
    public static ReplyKeyboardMarkup returnSecondMenu()
    {
        replyKeyboardMarkup = new ReplyKeyboardMarkup(new[] {
            new KeyboardButton[] { "Первый" },
            new KeyboardButton[] { "Второй" },
            new KeyboardButton[] { "Третий" },
            new KeyboardButton[] { "Четвёртый" },
            new KeyboardButton[] { "⬅Назад" },
        })
        {
            ResizeKeyboard = true
        };

        return replyKeyboardMarkup;
    }
    public static ReplyKeyboardMarkup return1kyrsMenu()
    {
        replyKeyboardMarkup = new ReplyKeyboardMarkup(new[] {
            new KeyboardButton[] { "ИС-120" },
            new KeyboardButton[] { "ВТ-180" },
            new KeyboardButton[] { "АЖ-180" },
            new KeyboardButton[] { "⬅⬅Назад" },
        })
        {
            ResizeKeyboard = true
        };

        return replyKeyboardMarkup;
    }
    public static ReplyKeyboardMarkup return2kyrsMenu()
    {
        replyKeyboardMarkup = new ReplyKeyboardMarkup(new[] {
            new KeyboardButton[] { "ИС-220" },
            new KeyboardButton[] { "ВТ-280" },
            new KeyboardButton[] { "АЖ-280" },
            new KeyboardButton[] { "⬅⬅Назад" },
        })
        {
            ResizeKeyboard = true
        };

        return replyKeyboardMarkup;
    }
    public static ReplyKeyboardMarkup return3kyrsMenu()
    {
        replyKeyboardMarkup = new ReplyKeyboardMarkup(new[] {
            new KeyboardButton[] { "ИС-320" },
            new KeyboardButton[] { "ВТ-380" },
            new KeyboardButton[] { "АЖ-380" },
            new KeyboardButton[] { "⬅⬅Назад" },
        })
        {
            ResizeKeyboard = true
        };

        return replyKeyboardMarkup;
    }
    public static ReplyKeyboardMarkup return4kyrsMenu()
    {
        replyKeyboardMarkup = new ReplyKeyboardMarkup(new[] {
            new KeyboardButton[] { "ИС-420" },
            new KeyboardButton[] { "ВТ-480" },
            new KeyboardButton[] { "АЖ-480" },
            new KeyboardButton[] { "⬅⬅Назад" },
        })
        {
            ResizeKeyboard = true
        };

        return replyKeyboardMarkup;
    }
    public static ReplyKeyboardMarkup Dennedeli()
    {
        replyKeyboardMarkup = new ReplyKeyboardMarkup(new[] {
            new KeyboardButton[] { "Понедельник" },
            new KeyboardButton[] { "Вторник" },
            new KeyboardButton[] { "Среда" },
            new KeyboardButton[] { "Четверг" },
            new KeyboardButton[] { "Пятница" },
            new KeyboardButton[] { "⬅⬅⬅Назад" },
        })
        {
            ResizeKeyboard = true
        };

        return replyKeyboardMarkup;
    }
}
