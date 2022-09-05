// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNumber(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void PrintSum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов = {sum} ");
    return;
  }
  PrintSum(m, n - 1, sum);
}


Console.Clear();
Console.WriteLine($"Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N");
int m = InputNumber("Введите меньшее натуральное число M: ");
int n = InputNumber("Введите меньшее натуральное число N: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSum(m, n, temp=0);