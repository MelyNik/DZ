/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Пример:
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();
Console.WriteLine($"Введите число А: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine($"Введите число В: ");
int numberB = int.Parse(Console.ReadLine());

void AToTheDegreeOfB(int number1, int number2)
{
    int i = 0;
    int number = number1;
    while (i < number2 - 1)
    {
        number1 = number1 * number;
        i++;
    }
    Console.WriteLine($"Число {number} в натуральной степени числа {number2} = {number1} ");
}

AToTheDegreeOfB(numberA, numberB);
