/*Задача 23

Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

/*Console.WriteLine("Input two integer numbers ()");

int Number = Convert.ToInt32(Console.ReadLine());
int Degree = Convert.ToInt32(Console.ReadLine());*/

double Exposure(double A, double b)
{
    double result = Convert.ToInt32(Math.Pow(A, b));
    return result;
}


int N = 5;
int Degree = 3;
double m = 1;
for (int i = 1; i <= N; i++)
{
    m = Exposure(i, Degree);
    Console.Write(" " + m);
}

/*Console.WriteLine("Input integer number ()");
int N = Convert.ToInt32(Console.ReadLine());

//int N =3;

int M = 1;

for (int i = 1; i <= N; i++)
{
    M = Convert.ToInt32(Math.Pow(i, 3));
    Console.Write(" " + M);
}*/

