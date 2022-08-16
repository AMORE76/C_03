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


/*void FillArray(int[] collection)
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

PrintArray(int[] array);

{
    int count = col.Length;
    int position = 0;

    while (position < count)

    {
        Console.WriteLine(col[position]);
        position++;
    }

    return position;
}

int[] array = new int[10];
void FillArray(int[] col);

FillArray(array);
PrintArray(array);

/*Console.WriteLine("Input eight-digit number ()");
int N = Convert.ToInt32(Console.ReadLine());

N = Math.Abs(N);

double NumberArray(int A)

{
   int [] array = new int[8];
    while (A != 0)
    {
        sum += A % 10;
        A /= 10;
    }
    double result = Convert.ToInt32(sum);
    return result;
}

double DigitSum = SumOfDigit(N);

Console.WriteLine(DigitSum);*/

