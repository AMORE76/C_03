/*Урок 5. Функции продолжение

Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/


Console.WriteLine("Input size of the Array:");
int N = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[N];

double DifferenceMaxAndMinElements(int N, double[] arr)
{
    Console.WriteLine("Array: ");

    for (int i = 0; i < N; i++)
    {
        arr[i] = new Random().NextDouble() * 100;
        Console.WriteLine(" " + arr[i]);
    }

    double min = arr[0];
    double max = arr[0];

    for (int i = 0; i < N; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        else if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    Console.WriteLine("\nMinimum element: " + min);
    Console.WriteLine("Maximum element: " + max);
    double result = max - min;
    Console.WriteLine("Difference between Maximum and Minimum array elements: " + result);
    return result;
}
DifferenceMaxAndMinElements(N, arr);


// int i = 0;
// Console.WriteLine("Введите размер массива:");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите элементы массива");
// int[] arr = new int[N];

// for (i = 0; i < N; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
//     //Console.Write("" + arr[i]);
// }

// int min = arr[0];
// int max = arr[0];

// for (i = 0; i < N; i++)
// {
//     if (arr[i] < min)
//     {
//         min = arr[i];
//     }
//     else if (arr[i] > max)
//     {
//         max = arr[i];
//     }
// }
// Console.WriteLine("\nМинимальный элемент: " + min);
// Console.WriteLine("Максимальный элемент: " + max);
// int result = max - min;
// Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + result);

