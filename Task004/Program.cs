// Задача 8: Напишите программу на сишарп, которая на вход принимает число (N), а на выходе
// показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// System.Console.WriteLine("Введите число: ");
// int number = Int32.Parse(Console.ReadLine()!);
// int i = 0;
// while (i % 2 == 0)
// {
//     System.Console.WriteLine($" {i++}");
// }

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Чётные числа от 1 до " + number + ":");
for (int i = 2; i <= number; i += 2)
{
    Console.Write($" {i} ");
}
