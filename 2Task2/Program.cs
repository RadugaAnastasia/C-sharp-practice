// Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, 
//то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse (Console.ReadLine()!);
int result = 0;
double result2 = 1;

if (b % a == 0)
{
    result = b / a;
    Console.WriteLine($" {b}, {a} -> кратно");
}
else
{
    result2 = b % a;
    Console.WriteLine($" {b}, {a} -> не кратно, остаток {result2}");
}