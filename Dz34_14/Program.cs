/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Пример:
[345, 897, 568, 234] -> 2
*/

int length = new Random().Next(5, 11);
int[] arr = new int[length];

void RandomArray(int[] array, int minValue, int maxValue)
{
    Console.Write($"Предоставлен массив из трёхзначных чисел: ");
    int sum = 0;
    int i = 0;
    while (i < array.Length)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{array[i]} ");
        if (array[i] % 2 == 0)
        {
            sum++;
        }
        i++;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество чётных чисел в массиве = {sum} ");
    Console.WriteLine();
}

RandomArray(arr, 100, 999);