/*
Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/



void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble()*100, 0);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ProductArrayStrings(double[,] array)
{
    double sum = 0;
    int i;
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        double result = Math.Round(sum / i, 1);
        Console.Write($"{result} ");
        sum = 0;
    }
    Console.WriteLine();
}

int line = new Random().Next(5, 10);
int column = new Random().Next(5, 10);
double[,] array = new double[line, column];

PrintArray(array);
ProductArrayStrings(array);