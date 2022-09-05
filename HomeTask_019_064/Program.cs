// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 4; N = 8. -> ""4, 6, 7, 8""



int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int FillArray(int[] collection, int start)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = start++;
        index++;
    }
    return start;
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write(collection[index] + ", ");
        index++;
    }
}


Console.Clear();
Console.WriteLine($"Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");

int n = InputNumber("Введите большее натуральное число N: ");
int m = InputNumber("Введите меньшее натуральное число M: ");
int length = (n - m) + 1;
int[] array = new int[length];

FillArray(array, m);
Console.Write(" '' ");
PrintArray(array);
Console.Write("The End");
Console.Write(" '' ");