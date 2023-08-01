// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine()!);

Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()!);

int Degree(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result *= numberA;
    }
    return result;
}

int result = Degree(numberA, numberB);
Console.WriteLine($"{numberA} в степени {numberB} равно {result}");
