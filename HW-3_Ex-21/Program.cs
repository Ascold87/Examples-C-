// №21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты первой точки (через Enter) ");
int xA = int.Parse(Console.ReadLine());
int yA = int.Parse(Console.ReadLine());
int zA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки (через Enter) ");
int xB = int.Parse(Console.ReadLine());
int yB = int.Parse(Console.ReadLine());
int zB = int.Parse(Console.ReadLine());
double result = Math.Sqrt(Math.Pow((xA - xB), 2) + Math.Pow((yA - yB), 2) + Math.Pow((zA - zB), 2));
result = Math.Round(result, 2);
Console.WriteLine("Расстояние между двумя точками составляет - " + result + " ед.");