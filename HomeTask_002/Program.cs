/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */


Console.WriteLine("Задайте координаты первой точки ()");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте координаты второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double f(double a1, double b1, double c1, double a2, double b2, double c2)

{
    double A = (a2 - a1);
    double B = (b2 - b1);
    double C = (c2 - c1);
    double result = Math.Sqrt((A * A) + (B * B) + (C * C));
    return result;
}

double length = f(x1, y1, z1, x2, y2, z2);

Console.WriteLine(length);

