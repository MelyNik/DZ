/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Пример:
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] GetArray(int line, int column, int thirdParty, int number)
{
    int[,,] array = new int[line, column, thirdParty];
    int sum = number;
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < thirdParty; k++)
            {
                array[i, j, k] = number + 1;
                number++;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Random r = new Random();
int lines = r.Next(3, 5);
int columns = r.Next(3, 5);
int thirdParty = r.Next(3, 5);
int number = 10;

int[,,] array = GetArray(lines, columns, thirdParty, number);
PrintArray(array);