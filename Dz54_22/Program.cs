/*
Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


int[,] GetArray(int line, int column, int min, int max)
{
    int[,] array = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int max = j;
            for (int l = j; l < array.GetLength(1); l++)
            {
                if (array[i, l] > array[i, max])
                {
                    max = l;
                }
            }
            int result = array[i, j];
            array[i, j] = array[i, max];
            array[i, max] = result;
        }
    }
    return array;
}

int lines = new Random().Next(3, 6);
int columns = new Random().Next(4, 7);

int[,] array = GetArray(lines, columns, -99, 100);
PrintArray(array);
Console.WriteLine();
PrintArray(ChangeArray(array));
