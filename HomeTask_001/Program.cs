/*Задача 19

Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/



Console.Write("Please input five-digit number: ");
string number = Console.ReadLine();

void pal(string number)

{
    if (number[0] == number[4] && number[1] == number[3])
    { Console.WriteLine($"{number} is Palindrome"); }
    else Console.WriteLine($"{number} is not Palindrome");
}

if (number.Length == 5)
{
    pal(number);
}
Console.WriteLine("Format of input number is uncorrect");



