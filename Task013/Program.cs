// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
metka:
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()!);
if (number < 0)
{
    number *= -1;
}
else if (number < 100)
{
    Console.WriteLine("Нет третьей цифры");
    goto metka;
}

while (number > 999)
{
    number /= 10;
}
int count = (number % 10);
Console.WriteLine($"Третья цифра вашего числа равна {count}");
