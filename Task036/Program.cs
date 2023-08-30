﻿using System;
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Random myRnd = new Random();// Объявляется генератор случайных чисел.
int[] a = new int[6];//Объявление целочисленного массива длинной 10.
Console.WriteLine("Исходный массив:");
for (int i = 0; i < a.Length; i++)//Цикл заполнения массива.
{
    a[i] = myRnd.Next(-99, 999);//Присвоение случайного числа от -99 до 999 [i]-тому элементу массива.
    Console.Write(a[i] + " ");//Вывод на экран.
}
int sum = 0;
for (int i = 1; i < a.Length; i += 1)
{
    if (i % 2 != 0) sum += a[i];
}
Console.WriteLine("Сумма =" + sum);


