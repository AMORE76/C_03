// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29


int InputNumber(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int AckermannFunction(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AckermannFunction(m - 1, 1);
  else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

Console.Clear();
Console.WriteLine($"Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
int m = InputNumber("Введите первое неотрицательное число m: ");
int n = InputNumber("Введите второе неотрицательное число n: ");

int Aсkerman = AckermannFunction(m, n);

Console.Write($"Функция Аккермана = {Aсkerman} ");