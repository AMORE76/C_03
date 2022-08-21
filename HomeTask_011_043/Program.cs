/* Задача 43: Напишите программу,
которая найдёт точку пересечения
двух прямых, заданных уравнениями:
 y = k1 * x + b1, 
 y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


int row = 2;
int col = 2;

int[,] StraightLine = new int[row, col];
{
    for (int i = 0; i < StraightLine.GetLength(0); i++)
    {
        for (int j = 0; j < StraightLine.GetLength(1); j++)

        {
            StraightLine[i, j] = new Random().Next(0, 10);
            Console.Write($"{StraightLine[i, j]} ");
        }
    }
}


int k1 = StraightLine[0, 0];
int k2 = StraightLine[1, 0];
int b1 = StraightLine[0, 1];
int b2 = StraightLine[1, 1];

// int k1 = 5;
// int k2 = 5;
// int b1 = 2;
// int b2 = 4;

// int k1 = 5;
// int k2 = 9;
// int b1 = 2;
// int b2 = 4;

Console.WriteLine("");
Console.WriteLine($"k1= {k1} ");
Console.WriteLine($"k2= {k2} ");
Console.WriteLine($"b1= {b1} ");
Console.WriteLine($"b2= {b2} ");


if (k1 != k2)
{
    double x = -(b1 - b2) / (k1 - k2);
    Console.WriteLine($"{x}");
    double y = k2 * x + b2;
    Console.WriteLine($"{y}");

    Console.WriteLine(" ");
    Console.WriteLine("Абсцисса точки пересечения прямых: " + $"{x}");
    Console.WriteLine("");
    Console.WriteLine("Ордината точки пересечения прямых: " + $"{y}");
}
else
{ Console.WriteLine("Прямые параллельны, то есть не пересекаются"); };

Console.WriteLine();

