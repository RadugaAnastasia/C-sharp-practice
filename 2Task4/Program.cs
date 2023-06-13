// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
// 5, 25 -> да 
// -4, 16 -> да 
// 25, 5 -> да 
// 8, 9 -> нет

// Console.Clear();
// Console.WriteLine("Введите первое число: ");
// int a = int.Parse (Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int b = int.Parse (Console.ReadLine()!);
// int x = 0; //квадрат меньшего числа
// if (a > b)
// {
//     x = b * b;
//     if (x == a)
//     {
//         Console.WriteLine($" {a}, {b} -> да");
//     }
// }
// else if (a <= b)
// {
//     x = a * a;
//     if (x == b)
//     {
//         Console.WriteLine($" {a}, {b} -> да");
//     }
//     else 
//     {
//         Console.WriteLine($" {a}, {b} -> нет");
//     }
// }

Console.WriteLine("Введите число:");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
int numberTwo = Convert.ToInt32(Console.ReadLine());

string res = "";
if(numberTwo * numberTwo != numberOne && numberOne * numberOne != numberTwo)
{
    res = ($" {a}, {b} -> нет");
}

else 
{
    res = ($" {a}, {b} -> да");
}
Console.WriteLine(res);