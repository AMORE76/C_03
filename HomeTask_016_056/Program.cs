// Урок 8.
// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateArrayRandomNumbers(int row, int col)
{
    int[,] numbers = new int[row, col];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
    return numbers;
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
int SumRow(int[,] array, int row)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum += array[row, i];
    }
    return sum;
}
void ItemRow(int[,] array)
{
    for (int i = 0; i < 1; i++)
    {
        int minSumRow = SumRow(array, row: i);
        int itemRow = i;
        for (int j = 1; j < array.GetLength(0); j++)
        {
            int sumRow = SumRow(array, row: j);
            if (sumRow < Convert.ToInt32(minSumRow))
            {
                minSumRow = sumRow;
                itemRow = j;
            }
        }
        Console.WriteLine($"String number: {itemRow + 1} with minimum sum of elements: {minSumRow}.");
    }
}

// int[,] numbers = CreateArrayRandomNumbers(row: 5, col: 8);
// PrintArray(numbers);
// Console.WriteLine();
// ItemRow(numbers);

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
        Console.WriteLine();
        ItemRow(matrix);
    }

}

Task();







