/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.(необязательная)
m = 2, n = 3 -> A(m,n) = 29
*/

int FunctionAkkerman(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if(m > 0 && n == 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }
    else if(m > 0 && n > 0)
    {
        return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    }
    else 
    {
        return FunctionAkkerman(m, n);
    }
}

Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FunctionAkkerman(m, n));