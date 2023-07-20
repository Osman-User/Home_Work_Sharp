// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Решение: (не забыть дополнить код для отрицательных значений)


System.Console.Write("Первое число: ");
int num1 = Int32.Parse(Console.ReadLine()!);

System.Console.Write("Второе число: ");
int num2 = Int32.Parse(Console.ReadLine()!);

if (num1 > num2)
{
    System.Console.WriteLine($"Наибольшее число: {num1}");
}
if (num2 > num1)
{
    System.Console.WriteLine($"Наибольшее число: {num2}");
}


// решение 2
// System.Console.Write("Введите первое число: ");
// double num1 = Int32.Parse(Console.ReadLine()!);

// System.Console.Write("Введите второе число: ");
// double num2 = Int32.Parse(Console.ReadLine()!);

// double max = num1;
// if (num2 > max)
//     max = num1;
// if (num1 > max)
//     max = num2;
// Console.Write($"Наибольшее число: {max}");

// решение 3
// System.Console.Write("Введите первое число: ");
// var num1 = Decimal.Parse(Console.ReadLine()!);

// System.Console.Write("Введите второе число: ");
// var num2 = Decimal.Parse(Console.ReadLine()!);

// if (num1 > num2)
// 	Console.WriteLine($"Наибольшее число: {num1}");
// else
// 	Console.WriteLine($"Наибольшее число: {num2}");
