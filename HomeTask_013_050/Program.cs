// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


int[,] array = new int[4, 4];

void FillArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            array[row, col] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0), cols = array.GetLength(1);
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            Console.Write($"{array[row, col],6}");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Input Number:");
int N = Convert.ToInt32(Console.ReadLine());
FillArray(array);
PrintArray(array);
Console.WriteLine();

int count = 0;
void FindN(int[,] array, int N)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        
        for (int col = 0; col < array.GetLength(1); col++)
        {
            if (array[row, col] == N)
            {
                Console.WriteLine($"The element has found! Row: {row + 1}, Column: {col + 1}");
                count++;
            }
        }
        
    }
     if (count == 0)
    {
        Console.WriteLine("The element has not found!");
    }

}
FindN(array, N);