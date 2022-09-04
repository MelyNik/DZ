﻿/*
Задайте значения M и N. Напишите программу, которая найдёт сумму 
чётных чисел натуральных элементов в промежутке от M до N.
Пример:
M = 1; N = 15 -> 56
M = 4; N = 8. -> 18
*/

int[] DeterminationMaximumNumber(int m, int n)
{
    int[] array = new int[2];
    int max = m;
    int min = n;
    if (n > max)
    {
        max = n;
        min = m;
    }
    array[0] = min;
    array[1] = max;
    return array;
}

Random r = new Random();
int m = r.Next(1, 20);
Console.WriteLine($"{m} ");
int n = r.Next(1, 20);
Console.WriteLine($"{n} ");
Console.WriteLine();

if (m == n)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"ОШИБКА!!! Между {m} и {n} нет промежутка натуральных чисел.");
    Console.ResetColor();
}
else
{
    int[] array = DeterminationMaximumNumber(m, n);
    if (array[0] % 2 == 0)
    {
        int sum = array[0];
        int result = sum;
        for (int i = array[0] + 2; i <= array[1]; i = i + 2)
        {
            sum = sum + 2;
            result = result + sum;
            Console.WriteLine(result);
        }
        Console.WriteLine($"Cумма чётных чисел натуральных элементов в промежутке от {array[0]} до {array[1]} = {result} \t");
    }
    else
    {
        int sum = array[0] + 1;
        int result = sum;
        for (int i = array[0] + 2; i <= array[1] - 1; i = i + 2)
        {
            sum = sum + 2;
            result = result + sum;
            Console.WriteLine(result);
        }
        Console.WriteLine($"Cумма чётных чисел натуральных элементов в промежутке от {array[0]} до {array[1]} = {result} \t");
    }
}