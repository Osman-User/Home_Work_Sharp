// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class Program
    {


        static void Main(string[] args)
        {

            Console.Write("Введите элементы: ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Кол-во элементов > 0: {count}");
            Console.Read();
        }
    }
}