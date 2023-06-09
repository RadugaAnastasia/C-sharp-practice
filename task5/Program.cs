// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число N: ");
int.TryParse(Console.ReadLine(), out int result);
string str1 = "";
for (int i = -result; i <= result; i++ )
{
    if (i == -result) 
    {
        str1 = i.ToString();
    }
    else 
    {
        str1 += ", " + i.ToString();
    }
}
Console.WriteLine($" {result} -> \" {str1} \"");