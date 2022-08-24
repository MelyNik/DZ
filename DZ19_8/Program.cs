/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Пример:
14212 -> нет
12821 -> да
23432 -> да
*/

/* Второй вариант

void PalindromeOfAnyNumber(int number)
{
    if (number < 999 && number > -999)
    {
        if (number / 10 == 0)
        {
            Console.WriteLine($"Число {number} не является палиндромом");
        }
        else if (number / 10 == number % 10)
        {
            Console.WriteLine($"Число {number} является палиндромом");
        }
        else if (number == 10 || number == -10)
        {
            Console.WriteLine($"Число {number} не является палиндромом");
        }
        else if (number / 100 == number % 10)
        {
            Console.WriteLine($"Число {number} является палиндромом");
        }
        else
        {
            Console.WriteLine($"Число {number} не является палиндромом");
        }
    }
    else
    {
        int i = 0;
        int numberA = number;
        while (numberA > 0)
        {
            numberA = numberA / 10;
            i++;
        }
        if (i % 2 == 0)
        {
            int j = i / 2;
            int k = j;
            int h = j - 1;
            while (j > 1)
            {
                if ((number / (long)Math.Pow(10, k)) % 10 == (number / (long)Math.Pow(10, h)) % 10) 
                {
                    j = j - 1;
                    h = h - 1;
                    k = k + 1;
                    if (h < 1)
                    {
                        if (number / (long)Math.Pow(10, k) == number % 10)
                        {
                            Console.WriteLine($"Число {number} является палиндромом");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Число {number} не является палиндромом");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Число {number} не является палиндромом");
                    break;
                }
            }
        }
        else
        {
            int j = i / 2;
            int k = j + 1;
            int h = j - 1;
            while (j > 1)
            {
                if ((number / (long)Math.Pow(10, k)) % 10 == (number / (long)Math.Pow(10, h)) % 10)
                {
                    j = j - 1;
                    h = h - 1;
                    k = k + 1;
                    if (h < 1)
                    {
                        if (number / (long)Math.Pow(10, k) == number % 10)
                        {
                            Console.WriteLine($"Число {number} является палиндромом");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Число {number} не является палиндромом");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Число {number} не является палиндромом");
                    break;
                }
            }
        }
    }
}

Console.WriteLine($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

PalindromeOfAnyNumber(number);
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

