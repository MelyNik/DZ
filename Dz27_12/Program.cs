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

void AddingDigitsOfANumber(int number)
{
    int i = 0;
    int counter1 = 0;
    int Division1 = number;
    while (i < Division1 || i > Division1)
    {
        Division1 = Division1 / 10;
        counter1++;
    }
    int counter2 = 0;
    int sum = 0;
    int Remains = 0;
    int Division2 = number;
    while (counter2 < counter1)
    {
        Remains = Division2 % 10;
        Division2 = Division2 / 10;
        sum = sum + Remains;
        counter1 = counter1 - 1;
    }
    Console.WriteLine($"Сумма цифр числа {number} = {sum} ");
}

AddingDigitsOfANumber(number);
