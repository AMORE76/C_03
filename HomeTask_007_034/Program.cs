/*Урок 5. Функции продолжение 
 
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.  
Напишите программу, которая покажет количество чётных чисел в массиве. 
 
[345, 897, 568, 234] -> 2*/

string GetNumber(int N)

{
    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(" ");
        Console.Write(" " + array[i] + " ");
    }

    int Quantity = 0;

    for (int i = 0; i < array.Length; i++)

    {
        if (array[i] % 2 == 0)

        {
            Quantity++;
        }
    }

    if (Quantity > 0)

        return ($"Number of Even Numbers: {Quantity}");

    else return "Only Odd Numbers";

}


Console.Write("Input size of the Array: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(GetNumber(N));




/*Урок 5. Функции продолжение

Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

/*string GetNumber()

{
    Console.Write("Введите размер массива: ");
    int N = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(" ");
        Console.Write(" " + array[i] + " ");
    }


    int Quantity = 0;
    string Answer = string.Empty;
    for (int i = 0; i < array.Length; i++)

    {
        if (array[i] % 2 == 0)

        {
            Quantity ++;
            Answer = $"Even Number {Quantity}";
        }

        else { Answer = $"Odd Number"; }
    }

    return Answer;
}

System.Console.WriteLine(GetNumber());*/

/*Console.Write("Введите размер массива : ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
int k = 0;
for (int i = 0; i < N; i++)
{
    arr[i] = new Random().Next(100, 1000);
    Console.Write("{0} ", arr[i]);
}
Console.WriteLine(" ");

foreach(int element in arr)
{
if (element % 2 == 0)
{
    k++;
}
}
Console.WriteLine();
Console.WriteLine("Количество четных элементов {0}", k);*/



/*Console.Write("Введите размер массива : ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
int count = 0;
int EvenNumbers(int N, int[] arr, int count)
{
    for (int i = 0; i < N; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        Console.Write("{0} ", arr[i]);
    }
    Console.WriteLine(" ");

    foreach (int element in arr)
    {
        if (element % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Количество четных элементов {0}", count);
    return count;
}
EvenNumbers(N, arr, count);*/