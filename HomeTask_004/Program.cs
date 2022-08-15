/*Урок 4. Функции продолжение
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

*/

Console.WriteLine("Input two integer numbers ()");

int Number = Convert.ToInt32(Console.ReadLine());
int Degree = Convert.ToInt32(Console.ReadLine());

double Exposure(double A, double b)

{
    double result = Convert.ToInt32(Math.Pow(A, b));
    return result;
}

double NumberInDegree = Exposure(Number, Degree);

Console.WriteLine(NumberInDegree);

