/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */


int[,] spiralArray = new int[4, 4];
int value = 1;

FillSpiralArray(spiralArray, value);

// Вывод заполненного массива
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(spiralArray[i, j] + "\t");
    }
    Console.WriteLine();
}


void FillSpiralArray(int[,] array, int value)
{
    int size = array.GetLength(0);
    int rowStart = 0;
    int rowEnd = size - 1;
    int colStart = 0;
    int colEnd = size - 1;

    while (rowStart <= rowEnd && colStart <= colEnd)
    {
        // Заполнение верхней строки
        for (int i = colStart; i <= colEnd; i++)
        {
            array[rowStart, i] = value++;
        }
        rowStart++;

        // Заполнение последнего столбца
        for (int i = rowStart; i <= rowEnd; i++)
        {
            array[i, colEnd] = value++;
        }
        colEnd--;

        if (rowStart <= rowEnd)
        {
            // Заполнение нижней строки
            for (int i = colEnd; i >= colStart; i--)
            {
                array[rowEnd, i] = value++;
            }
            rowEnd--;
        }

        if (colStart <= colEnd)
        {
            // Заполнение первого столбца
            for (int i = rowEnd; i >= rowStart; i--)
            {
                array[i, colStart] = value++;
            }
            colStart++;
        }
    }
}
