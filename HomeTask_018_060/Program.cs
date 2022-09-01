/*Урок 8.
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2.*/
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

bool TestNumberForNonRepetition(int[,,] array, int searchNumber)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                if (array[x, y, x] == searchNumber)
                {
                    return false;
                }
            }
        }
    }
    return true;
}
void FillArray(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                while (true)
                {
                    int number = new Random().Next(10, 100);
                    if (TestNumberForNonRepetition(array, number))
                    {
                        array[y, z, x] = number;
                        break;
                    }
                }
            }
        }
    }
}
void PrintArray(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($"{array[y, z, x]} (у:{y}, z:{z}, x:{x}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] matrix = new int[2, 2, 2];
FillArray(matrix);
PrintArray(matrix);