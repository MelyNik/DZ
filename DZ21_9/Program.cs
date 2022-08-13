/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Пример:
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координаты точки A: ");
double pointAx = Convert.ToDouble(Console.ReadLine());
double pointAy = Convert.ToDouble(Console.ReadLine());
double pointAz = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
double pointBx = Convert.ToDouble(Console.ReadLine());
double pointBy = Convert.ToDouble(Console.ReadLine());
double pointBz = Convert.ToDouble(Console.ReadLine());


double lengthC = Math.Sqrt(Math.Pow((pointAx - pointBx), 2) + Math.Pow((pointAy - pointBy), 2) + Math.Pow((pointAz - pointBz), 2));
Console.WriteLine(Math.Round(lengthC, 2));
