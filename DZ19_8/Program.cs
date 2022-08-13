/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Пример:
14212 -> нет
12821 -> да
23432 -> да
*/

/*
Первый вариант

Console.WriteLine($"Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99999 && number > -99999)
{
    Console.ForegroundColor = ConsoleColor.Red; // Окрасили текст ниже в красный.
    Console.WriteLine($"ОШИБКА!: Число {number} не является пятизначным числом");
    Console.ResetColor();
}
else if(number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
{

    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}
*/

// Второй вариант

void ConfirmatioPoly(int number)
{
    if (number < 10 && number < -10)
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
    int i = 0;
    while (i < 1)
    {
        if (number/ 100 == 0 && number == number % 10)
        {
            Console.WriteLine($"Число {number} является палиндромом");
        }
        else
        {
            Console.WriteLine($"Число {number} не является палиндромом");
        }
        i = 1;
    }
}


Console.WriteLine($"Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

ConfirmatioPoly(number);