/*
Задайте две матрицы. Напишите программу, которая 
будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] GetArray1(int line, int column, int min, int max)
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

int[,] GetArray2(int line, int column, int min, int max)
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

int[,] CompositionMatrix1(int[,] matrix1, int[,] matrix2)
{
    int l = 0;
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        int k = 0;
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int sum = 0;
            for (int c = 0; c < matrix2.GetLength(0); c++)
            {
                sum = sum + matrix1[i, c] * matrix2[c, k];
            }
            result[l, j] = sum;
            k++;
        }
    }
    return result;
}

Random r = new Random();
int lines1Matrix = r.Next(3, 6);
int columns1Matrix = r.Next(3, 6);
Console.WriteLine($"Строк первой матрицы = {lines1Matrix}, столбцов = {columns1Matrix}");

int lines2Matrix = r.Next(3, 6);
int columns2Matrix = r.Next(3, 6);
Console.WriteLine($"Строк второй матрицы = {lines2Matrix}, столбцов = {columns2Matrix}");

if (columns1Matrix == lines2Matrix)
{
    int[,] matrixOne = GetArray1(lines1Matrix, columns1Matrix, 1, 10);
    int[,] matrixTwo = GetArray2(lines2Matrix, columns2Matrix, 1, 10);

    PrintArray(matrixOne);
    Console.WriteLine();
    PrintArray(matrixTwo);
    Console.WriteLine();

    int[,] result = CompositionMatrix1(matrixOne, matrixTwo);
    PrintArray(result);
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"ОШИБКА!!! Количество столбцов первой матрицы не равно количесвту строк второй");
    Console.ResetColor();
}

