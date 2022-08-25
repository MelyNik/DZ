/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Пример:
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] EnteringNumbers(int length)
{
    int[] array = new int[length];
    for(int i = 0; i<length; i++)
    {
        Console.Write($"Введите число {i+1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    } 
    return array;
}

int NumberOfPositiveNumbers(int[] array)
{
    int j = 0;
    for(int i =0; i<array.Length; i++)
    {
        if(array[i]>0)
        {
            j++;
        }
    }
    return j;
}

Console.Write($"Введи количество чисел готовых к вводу: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] array = EnteringNumbers(count);
int quantity = NumberOfPositiveNumbers(array);
Console.WriteLine($"Введено чисел больше 0 -> {quantity}");


