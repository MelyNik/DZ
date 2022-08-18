/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
(на примерах демонстрация выводов 5 и 3 размерных массивов, вам же нужно сделать 8)
Пример:
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


int Length = 8;
int[] arr = new int[Length];

void RandomArrayDigitsAndPrint(int[] array)
{
    Console.WriteLine($"Массив из {array.Length} элементов: ");
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,100);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

RandomArrayDigitsAndPrint(arr);

