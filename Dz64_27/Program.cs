/*
Задайте значения M и N. Напишите программу, которая выведет все 
натуральные числа в промежутке от M до N от большего к меньшему.
Пример:
M = 1; N = 5. -> ""5, 4, 3, 2, 1""
M = 4; N = 8. -> ""8, 7, 6, 5, 4""
*/
/*
int[] DeterminationMaximumNumber(int m, int n)
{
    int[] array = new int[2];
    int max = m;
    int min = n;
    if (n > max)
    {
        max = n;
        min = m;
    }
    array[0] = max;
    array[1] = min;
    return array; 
}


Random r = new Random();
int m = r.Next(1, 9);
Console.WriteLine($"{m} ");
int n = r.Next(1, 9);
Console.WriteLine($"{n} ");
Console.WriteLine();

if (m == n)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"ОШИБКА!!! Между {m} и {n} нет промежутке натуральных чисел.");
    Console.ResetColor();
}
else
{
    int[] array = DeterminationMaximumNumber(m,n);
    for(int i = array[0]; i > array[1]-1; i--)
    {
    Console.Write($"{i} \t");
    }
}
*/

// Рекурсия:

string Decreasing(int m, int n)
{
    if(m>n)
    {
        if(m==n)
        {
            return $"";
        }
        else
        {
            return $"{m}" + Decreasing(m-1,n);
        }
    }
    else if(n>m)
    {
        if(n==m)
        {
            return $"";
        }
        else
        {
            return $"{n}" + Decreasing(m,n-1);
        }
    }
    else if(m==n)
    {
        return $"{m}";
    }
    return $"";
}

Random r = new Random();
int m = r.Next(1,10);
Console.WriteLine(m);
int n = r.Next(1,10);
Console.WriteLine(n);

Console.WriteLine(Decreasing(m,n));
