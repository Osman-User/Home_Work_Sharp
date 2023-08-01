// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и
// проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели: ");
int dayNumber = int.Parse(Console.ReadLine()!);

string dayName = GetDayName(dayNumber);

Console.WriteLine($"День недели: {dayName}");

bool isWeekend = IsWeekend(dayNumber);

if (isWeekend)
{
    Console.WriteLine("Этот день является выходным.");
}
else
{
    Console.WriteLine("Этот день не является выходным.");
}

static string GetDayName(int dayNumber)
{
    switch (dayNumber)
    {
        case 1:
            return "Понедельник";
        case 2:
            return "Вторник";
        case 3:
            return "Среда";
        case 4:
            return "Четверг";
        case 5:
            return "Пятница";
        case 6:
            return "Суббота";
        case 7:
            return "Воскресенье";
        default:
            return "Неверная цифра дня недели";
    }
}

static bool IsWeekend(int dayNumber)
{
    return dayNumber == 6 || dayNumber == 7;
}
