// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y)

int Prompt(string message) //описываем метод, который работает с пользователем
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void FindRange(int n)
{
if(n == 1)
{
    Console.WriteLine("X>0, Y>0");
}
else if(n == 2)
{
    Console.WriteLine("X<0, Y>0");
}
else if(n == 3)
{
    Console.WriteLine("X<0, Y<0");
}
else if(n == 4)
{
    Console.WriteLine("X>0, Y<0");
}
else
{
    Console.WriteLine("Ошибка!");
}
}

int N = Prompt("Введите номер четверти: ");
FindRange(N);