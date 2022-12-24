// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координаты точки A: ");
Console.Write("X: ");
int xA=int.Parse(Console.ReadLine());
Console.Write("Y: ");
int yA=int.Parse(Console.ReadLine());
Console.Write("Z: ");
int zA=int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.Write("X: ");
int xB=int.Parse(Console.ReadLine());
Console.Write("Y: ");
int yB=int.Parse(Console.ReadLine());
Console.Write("Z: ");
int zB=int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(xB-xA, 2) + Math.Pow(yB-yA, 2) + Math.Pow(zB-zA, 2));
Console.WriteLine();
Console.WriteLine($"А ({xA}, {yA}, {zA}); B ({xB}, {yB}, {zB}), -> {d:f5}");
Console.WriteLine();
