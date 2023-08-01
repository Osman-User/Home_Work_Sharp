// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);

// Решение 1
// int digit1 = number / 10000; // Получаем первую цифру числа
// int digit2 = (number / 1000) % 10; // Получаем вторую цифру числа
// int digit4 = (number / 10) % 10; // Получаем четвертую цифру числа
// int digit5 = number % 10; // Получаем пятую цифру числа

// if (digit1 == digit5 && digit2 == digit4)
// {
//     Console.WriteLine("Число {0} является палиндромом.", number);
// }
// else
// {
//     Console.WriteLine("Число {0} не является палиндромом.", number);
// }

// Решение 2
if (IsPalindrome(number))
{
    Console.WriteLine("Число {0} является палиндромом.", number);
}
else
{
    Console.WriteLine("Число {0} не является палиндромом.", number);
}

bool IsPalindrome(int number)
{
    int originalNumber = Math.Abs(number);
    int reversedNumber = 0;

    while (number > 0)
    {
        int digit = number % 10;
        reversedNumber = reversedNumber * 10 + digit;
        number /= 10;
    }

    return originalNumber == reversedNumber;
}
