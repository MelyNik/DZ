/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Пример:
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();
Console.WriteLine($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = 0;
int counter1 = 0;
int Division = 0;
while(i<number || i>number)
{
    Division = number / 10;
    counter1++;
}
int counter2 = 0;
int sum = 0;
int Remains = 0;
while(counter2<counter1)
{
    Remains = number % 10;
    number = number / 10;
    sum = sum + Remains;
    counter1 = counter1 - 1;
    Console.WriteLine(sum);
}
Console.WriteLine(sum);