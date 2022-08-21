/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 и 
сколько чисел меньше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

//System.Console.WriteLine("Введите"+ $"{M}"+"целых положительных или отрицательных чисел");


string GetNumber(int M)

{
    int[] array = new int[M];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
        Console.WriteLine(" ");
        Console.Write(" " + array[i] + " ");        
    }

    Console.WriteLine(" ");
    Console.WriteLine(" ");

    int PositiveQuantity = 0;
    int NegativeQuantity = 0;
    string PlusAnswer = string.Empty;
    string MinusAnswer = string.Empty;

    for (int i = 0; i < array.Length; i++)

    {
        if (array[i] > 0)

        {
            PositiveQuantity++;
            PlusAnswer = $"Positive Number {PositiveQuantity}";
        }

        else

        {
            NegativeQuantity++;
            MinusAnswer = $"Negative Number {NegativeQuantity}";
        }
    }

    return PlusAnswer + " " + MinusAnswer;

}

Console.WriteLine(" ");

int M = new Random().Next(1, 10);
System.Console.WriteLine("M = " + $"{M}");
System.Console.WriteLine(GetNumber(M));

