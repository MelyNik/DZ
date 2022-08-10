/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
Пример:
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру дня недели:");
int number = Convert.ToInt32(Console.ReadLine());

if (number>7 || number < 1)
{
    Console.WriteLine($"Дня недели с такой цифрой {number} не существует");
}
else if(number > 5 & number < 8)
{
    Console.WriteLine($"{number} -> да");
}
else
{
    Console.WriteLine($"{number} -> нет");
}