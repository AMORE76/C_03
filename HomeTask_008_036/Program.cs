/*Урок 5. Функции продолжение

Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

int result = 0;

Console.WriteLine("Input size of the Array:");
int N = int.Parse(Console.ReadLine());
int[] arr = new int[N];

int SumOfOddNumbers(int result, int[] arr)
{
    Console.WriteLine(" ");
    Console.Write("Array: ");

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
        Console.Write(arr[i] + " ");
    }

    Console.WriteLine(" ");
    Console.Write("Odd Numbers: ");

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0)
        {
            result += arr[i];
            Console.Write(arr[i] + " ");
        }

    }

    Console.WriteLine(" ");
    Console.WriteLine($"Sum Of Odd Numbers: {result}");
    return result;
}
SumOfOddNumbers(result, arr);

// int result = 0;
// Console.WriteLine("Введите размер массива:");
// int N = int.Parse(Console.ReadLine());
// int[] a = new int[N];
// for (int i = 0; i < a.Length; i++)
// {
//     a[i] = new Random().Next(1, 10);
//     Console.Write(a[i] + " ");
// }
// Console.WriteLine(" ");
// for (int i = 0; i < a.Length; i++)
// {
//     if (a[i] % 2 != 0)
//     {
//         result += a[i];
//         Console.Write(a[i] + " ");
//     }

// }
// Console.WriteLine(" ");
// Console.WriteLine($"Сумма нечетных элементов массива : {result}");


