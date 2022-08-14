string Method4(int count, string text)
{
string result = String.Empty;
for (int i = 0; i<count; i++) 

/*вначале ключевое слово, затем инициализация
счётчика, после проверка условия и инкремент (увеличение счётчика)*/
{
result = result + text;
}
return result;
}
string res = Method4(10, "abc");
Console.WriteLine(res);

