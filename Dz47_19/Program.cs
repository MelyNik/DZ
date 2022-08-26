/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Пример:
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


int m = new Random().Next(3, 6);
int n = new Random().Next(3, 6);
double[,] array = new double[m, n];

void TwoDimensionalArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * 5, 1);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

TwoDimensionalArray(array);