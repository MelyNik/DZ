/*
Напишите программу, которая заполнит спирально массив 4 на 4. ( - необязательная)
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] GetArray(int line, int column, int min, int max)
{
    int[,] array = new int[line, column];
    array[0,0] = 01;
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if(array[i,j] % 100 == 01)
            {
                
            }
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

int lines = 4;
int columns = 4;

