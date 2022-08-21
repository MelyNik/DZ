/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(по индексу считаем).
Пример:
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int length = new Random().Next(5,11);
int[] arr = new int[length];

void RandomArray(int[] array, int minValue, int maxValue)
{
    Console.Write($"Предоставлен массив: ");
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
        Console.Write($"{array[i]} ");
        if(i % 2 == 0)
        {
            sum = sum + array[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов массива с чётным индексом = {sum} ");
    Console.WriteLine();
}

RandomArray(arr, 1, 99);

