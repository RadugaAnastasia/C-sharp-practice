// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
//  в которой находится эта точка

//Console.Clear();

int Prompt(string message) //описываем метод, который работает с пользователем
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
void FindQuarter(int X, int Y)
{
if(X>0 && Y>0)
{
    Console.WriteLine("I четверть");
}
else if(X<0 && Y>0)
{
    Console.WriteLine("II четверть");
}
else if (X<0 && Y<0)
{
    Console.WriteLine("III четверть");
}
else if (X>0 && Y<0)
{
    Console.WriteLine("IV четверть");
}
else
{
    Console.WriteLine("Ошибка!");
}
}

int x = Prompt("Введите координату точки Х: ");
int y = Prompt("Введите координату точки Y: ");
FindQuarter(x,y);