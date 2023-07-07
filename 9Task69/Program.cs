// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B(степень): ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"A = {A}; B = {B} -> {Pow(A, B)}");

//быстрое возведение в степень
int Pow(int a, int b) 
{
    if(b == 0)
    {
        return 1;
    }
    int temp = Pow(a, b/2);
    int temp2 = (b % 2 == 1)? a: 1;
    return temp * temp * temp2;
}

// //медленное возведение в степень
// int Pow(int a, int b) 
// {
//     if (b == 0)
//     {
//         return 1;
//     }
//     return Pow(a, b-1) * A;
// }