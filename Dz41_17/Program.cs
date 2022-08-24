/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Пример:
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

void NumberM(int number1, int number2, int number3)
{
    int i = 0;
    int j = 0;
    while (i < 3)
    {
        if (number1 > 0)
        {
            j++;
            number1 = number1 - number1;
        }
        else if (number2 > 0)
        {
            j++;
            number2 = number2 - number2;
        }
        else if (number3 > 0)
        {
            j++;
            number3 = number3 - number3;
        }
        i++;
    }
    Console.WriteLine($"{j}");
}

NumberM(number1, number2, number3);
