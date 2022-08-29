/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
(на вход именно поступает позиция элемента, можете разбить на две переменные или 
прописать в одну строку и конвертировать в два числа, комментарии в конце семинара по этой задаче)
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/


int[,] TwoDimensionalArray(int line, int columns, int min, int max)
{
    int[,] array = new int[line, columns];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
        Console.WriteLine();
    }
    return array;
}
void PrintArray(int[,] array)
{
   for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    } 
}

void FindingCoordinatesTwoDimensionalArray(int[,] array, int line, int column)
{
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (line == i && column ==  j)
            {
                Console.WriteLine($"Элемент массива с координатами ({line},{column}) -> {array[i, j]} ");
                k = 1;
            }
        }
    }
    if (k == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"ОШИБКА!!! Элемент массива с координатами ({line},{column}) -> отсутсвует ");
        Console.ResetColor();
    }
}

Console.WriteLine($"Введите номер строки: ");
int line = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] array = TwoDimensionalArray(9,9,-99,100);
PrintArray(array);
FindingCoordinatesTwoDimensionalArray(array, line, column);
