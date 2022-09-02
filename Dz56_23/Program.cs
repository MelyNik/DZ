/*
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка
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

int[] SumLineArray(int[,] array,int line)
{
    int[] arr = new int[line];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        arr[i] = sum;
    }
    return arr;
}

int FindingTheMinimumString(int[] arr)
{
    int min = arr[0];
    int result = 1;
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i]<min)
        {
            min = arr[i];
            result = i+1;
        }
    }
    return result;
}

int lines = 6;
int columns = 5;

int[,] array = GetArray(lines, columns, 0, 20);
PrintArray(array);
Console.WriteLine();

int[] arr = SumLineArray(array, lines);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {FindingTheMinimumString(arr)}");

