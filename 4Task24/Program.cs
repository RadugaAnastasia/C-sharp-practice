// Задача 24: Напишите программу, которая принимает
//  на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num; 
}

int GetSum(int a)
{
    int sum = 0;
    for(int i = 1; i <= a; i++)
    {
        sum += i; //sum = sum + i
        // Console.Write(i + " ");
    }
    return sum;
}

int number = Prompt("Введите число: ");
int result = GetSum(number);
Console.WriteLine("Сумма чисел от 1 до А = " + result);