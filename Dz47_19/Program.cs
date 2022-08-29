/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Пример:
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


double[,] GetArray(int line, int columns)
{
    double[,] array = new double[line, columns];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * 5, 1);
        }
    }
    return array;
}

void PrintArray(double[,] array)
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

int m = new Random().Next(3, 6);
int n = new Random().Next(3, 6);

double[,] array = GetArray(m,n);

PrintArray(array);