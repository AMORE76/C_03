// 1.Напишите метод, который возвращает массив из N элементов, 
// заполненный нулями и единицами в случайном порядке.


// N = 3 => [1, 0, 0]
// N = 8 => [1,0,1,1,0,1,0,0]


int[] GetBinaryArray(int n)
{
  int[] arr = new int[n];
  for (int i = 0; i < n; i++)
  {
    arr[i] = new Random().Next(0, 2);
  }
  return arr;
}

void Print(int[] arr)
{
  int size = arr.Length;
  for (int i = 0; i < size; i++)
  {
    System.Console.Write(arr[i]);
  }
}

string NewPrint(int[] arr)
{
  string s = String.Empty;
  int size = arr.Length;
  for (int i = 0; i < size; i++)
  {
    s += Convert.ToString(arr[i]);
  }
  return s;
}


// // Клиентский код
// int[] res = GetBinaryArray(10);
// //Print(res);

// string s = NewPrint(res);
// Console.WriteLine($"s: {s}");















