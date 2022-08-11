/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
Пример:
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int FindingTheThirdDigitOfANumber(int number)
{
    int stage1 = number / 100;
    int index = 0;
    while (stage1 > 1)
    {
        index++;
        stage1 = stage1 / 10;
        if (stage1 == 1)
        {
            index++;
        }
    }
    int stage2 = number;
    while (index > 1)
    {
        index = index - 1;
        stage2 = stage2 / 10;
    }
    stage2 = stage2 % 10;
    return stage2;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 && number > -100)
{
    Console.WriteLine($"Третьей цифры числа {number} - нет");
}
else
{
    int result = FindingTheThirdDigitOfANumber(number);
    Console.WriteLine($"Третья цифра числа {number} - {result}");
}
