/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

Console.WriteLine("Input integer number ()");
int N = Convert.ToInt32(Console.ReadLine());

N = Math.Abs(N);

double SumOfDigit(int A)

{
    double sum = 0;
    while (A != 0)
    {
        sum += A % 10;
        A /= 10;
    }
    double result = Convert.ToInt32(sum);
    return result;
}

double DigitSum = SumOfDigit(N);

Console.WriteLine(DigitSum);
