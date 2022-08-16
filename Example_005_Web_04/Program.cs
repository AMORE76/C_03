// // 3.написать метод, который принимает на вход
// десятичное представление числа N и показатель основания СС P, в которую
// нужно перевести это число

// N = 31, P = 2 => 11111
// N = 31, P = 8 => 37

// ДОГОВОРИМСЯ, что  2<= p <= 9

int[] DecToP(int dec, int p)
{

  int size = 5;
  int[] res = new int[size + 1];


  while (dec != 0)
  {
    int o = dec % p;
    dec = dec / p;
    res[size] = o;
    size--;
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

int[] resP = DecToP(234, 9);
Console.WriteLine($"NewPrint: {NewPrint(resP)}");
