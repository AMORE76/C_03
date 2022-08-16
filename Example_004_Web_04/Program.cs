// 2.написать метод, который принимает на вход
// двоичное представление числа в виде массива ARR и выдаёт
// десятичное представление

// ARR = [1, 0, 0] => 4
// ARR = [1, 0, 1, 1, 0, 1, 0, 0] => 180

double BinToDec(int[] arr)
{
  // 3210
  // 1101
  // 0123
  double res = 0;
  int size = arr.Length;
  for (int i = 0; i < size; i++)
  {
    res += arr[i] * Math.Pow(2, size - 1 - i);
  }
  return res;
}


// // Клиентский код
// int[] res = GetBinaryArray(4);
// //Print(res);

// string s = NewPrint(res);
// Console.WriteLine($"s: {s}");
// Console.ReadLine();
// double dec = BinToDec(res);
// Console.WriteLine($"dec: {dec}");

