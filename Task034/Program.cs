// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Size;

do
{
    Console.Write("Введите размер массива:  ");
    Size = Convert.ToInt32(Console.ReadLine());
}
while (Size <= 0);

int[] array = new int[Size];


int PrintArray(int[] intArray)
{
    Console.Write("[");
    for (int i = 0; i < intArray.Length; i++)
        if (i < Size - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else
        {
            Console.Write(array[i]);
        }
    Console.WriteLine("]");
    return 1;
}

int CreatArray(int[] intArray)
{
    for (int i = 0; i < intArray.Length; i++)
        array[i] = new Random().Next(100, 1001);
    return 1;
}

int EvenNumber(int[] intArray)
{
    int count = 0;
    for (int i = 0; i < intArray.Length; i++)
        if (array[i] % 2 == 0)
        {
            count++;
        }
    return count;
}



CreatArray(array);

PrintArray(array);

Console.WriteLine($"Количество чётных чисел в массиве: {EvenNumber(array)}");