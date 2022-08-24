/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Пример:
[3 7 22 2 78] -> 76
*/

int length = new Random().Next(5,15);
double[] arr = new double[length];

void RandomArray(double[] array, int minValue, int maxValue)
{
    Console.Write($"Создан массив: ");
    for(int i=0; i<array.Length; i++)
    {
        array[i] =Math.Round(new Random().NextDouble()*5, 2);// NextDouble() - означает от 0 до 1, если добавить * 5, то от 0 до 5.
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void DifferenceMaxElementAndMinElementArray(double[] array)
{
    double max = 0;
    double min = array[0];
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
    Console.WriteLine($"Разница максимального - {max} и минимального - {min} элементов массива = {Math.Round(max - min, 2)}");
}

RandomArray(arr, 0, 99);
DifferenceMaxElementAndMinElementArray(arr);