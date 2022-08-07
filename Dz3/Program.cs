/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Пример:
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число:");
int numberA = Convert.ToInt32(Console.ReadLine());

numberA = numberA % 2;
if ( numberA == 0 ) 
Console.WriteLine($"Число является чётным");
else
{
    Console.WriteLine($"Число не является чётным");
}