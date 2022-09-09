/*
Напишите программу, которая заполнит спирально массив 4 на 4. ( - необязательная)
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/



int[,] GetArray(int line, int column)
{
    int i = 0;
    int j = 0;
    int[,] array = new int[line, column];
    int startI = 0;
    int finishI = 0;
    int startJ = 0;
    int finishJ = 0;
    for (int c = 1; c <= array.GetLength(0) * array.GetLength(1); c++)
    {
        array[i, j] = c;
        if (i == startI && j < array.GetLength(1) - finishJ - 1)
        {
            j++;
        }
        else if (j == array.GetLength(1) - finishJ - 1 && i < array.GetLength(0) - finishI - 1)
        {
            i++;
        }
        else if (i == array.GetLength(0) - finishI - 1 && j > startJ)
        {
            j--;
        }
        else
        {
            i--;
        }
        if ((i == startI + 1) && (j == startJ) && (startJ != array.GetLength(1) - finishJ - 1))
        {
            startI++;
            startJ++;
            finishI++;
            finishJ++;
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
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Random r = new Random();
int lines = r.Next(3,6);
int columns = r.Next(3,6);

int[,] array = GetArray(lines, columns);
PrintArray(array);





