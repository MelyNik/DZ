/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Пример:
[3 7 22 2 78] -> 76
*/

int length = new Random().Next(5,15);
int[] arr = new int[length];

void RandomArray(int[] array, int minValue, int maxValue)
{
    Console.Write($"Создан массив: ");
    for(int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(minValue,maxValue+1);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void DifferenceMaxElementAndMinElementArray(int[] array)
{
    int max = 0;
    int min = array[0];
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        else if(array[i]<min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($"Разница максимального - {max} и минимального - {min} элементов массива = {max - min}");
}

RandomArray(arr, 0, 99);
DifferenceMaxElementAndMinElementArray(arr);