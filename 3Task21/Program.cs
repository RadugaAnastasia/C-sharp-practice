// Напишите программу, которая принимает на вход
//  координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void Rasst(int xa, int xb, int ya, int yb)
{
    double AB = Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya));
    Console.WriteLine(AB);
}

int XA = Prompt("Введите координату точки xa: ");
int YA = Prompt("Введите координату точки ya: ");
int XB = Prompt("Введите координату точки xb: ");
int YB = Prompt("Введите координату точки yb: ");
Rasst (XA, XB, YA, YB);