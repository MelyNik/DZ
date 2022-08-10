/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.
Пример:
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int digit1And2 = number / 10;
int digit2 = digit1And2 % 10;

Console.WriteLine($"{number} -> {digit2}");



