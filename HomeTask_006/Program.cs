/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

int [] numbers = new int[8];

int Method (int a)
{
    return numbers[a];
}


Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 11);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");


/* int[] array = new int[8];

//Cоздаем новый массив, где будет 8 элементов. По
умолчанию, он будет наполнен нулями.

void FillArray(int[] collection)

{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

// Оформляем метод void, который будет печатать массив.

void PrintArray(int[] col)

{int count = col.Length;
int position = 0;

while (position < count)

{Console.WriteLine(col[position]);
position++;}
}

FillArray(array);
Console.Write("[");
PrintArray(array);
Console.Write("]");*/

/* Определен массив из 8 элементов. Вызван метод FillArray,
который заполнил массив, вызван метод PrintArray, который распечатал массив.*/

