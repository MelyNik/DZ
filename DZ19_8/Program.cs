/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Пример:
14212 -> нет
12821 -> да
23432 -> да
*/

/* Второй вариант

int QuantityIndex(int number)
{
    int index = 0;
    while (number > 1)
    {
        number = number / 10;
        index = index + 1;
    }
    if (number == 1)
    {
        index = index + 1;
    }
    return index;
}

void ConfirmatioPoly(int number, int index)
{
    int stage = number;
    while (index > 1)
    {
        index = index - 1;
        stage = stage / 10;
    }
    if (stage / 10 == number % 10)
    {
        int stage2 = number;
        while (stage2 > 0)
        {
            stage2 = number / 100;
        }
    }
}

Console.WriteLine($"Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10 || number < -10)
{
    Console.WriteLine($"Число {number} не является палиндромом");
}
else
{
    int index = QuantityIndex(number);
    ConfirmatioPoly(number, index);
}
*/

// Первый вариант

Console.WriteLine($"Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99999 && number > -99999)
{
    Console.ForegroundColor = ConsoleColor.Red; // Окрасили текст ниже в красный.
        Console.WriteLine($"ОШИБКА!: Число {number} не является пятизначным числом");
        Console.ResetColor();
}
else if (number < 10000 && number > -10000)
    {
        Console.ForegroundColor = ConsoleColor.Red; // Окрасили текст ниже в красный.
        Console.WriteLine($"ОШИБКА!: Число {number} не является пятизначным числом");
        Console.ResetColor();
    }
    else if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
    {

        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }

