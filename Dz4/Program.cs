/*
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Пример:
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Выводим чётные числа:");
for ( int i = 2; numberA > i; i += 2 )
{
    Console.Write($" {i} ");
}