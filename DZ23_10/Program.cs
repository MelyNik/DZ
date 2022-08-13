/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Пример:
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void TableCube(int number)
{
    int index = 1;
    Console.Write($"Таблица кубов от 1 до {number}: -> ");
    while (index <= number)
    {

        Console.Write($"{index * index * index}, ");
        index++;
    }
}

Console.WriteLine($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

TableCube(number);