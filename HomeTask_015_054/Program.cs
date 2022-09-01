// Урок 8. 
// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// 
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateArrayRandomNumbers(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void SortArray(int[,] array, int row)
{
    for (int i = 0; i <= array.GetLength(0) - 1; i++)
    {
        int maxPos = i;
        for (int j = i + 1; j <= array.GetLength(0) - 1; j++)
        {
            if (array[row, j] > array[row, maxPos]) maxPos = j;
        }
        int temporary = array[row, i];
        array[row, i] = array[row, maxPos];
        array[row, maxPos] = temporary;
    }
}


int Input(string text)
{
    bool f = false;
    int number = 0;
    while (!f)
    {
        System.Console.Write(text);
        string str = Console.ReadLine();
        f = int.TryParse(str, out number);
    }
    return number;
}


void Task()
{

    int m = Input("rows:");
    int n = Input("columns:");

    if (m >= 0 && n >= 0)


    {
        int[,] matrix = CreateArrayRandomNumbers(m, n);
        PrintArray(matrix);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            SortArray(matrix, i);
        }
        System.Console.WriteLine();
        PrintArray(matrix);
    }

}

Task();



