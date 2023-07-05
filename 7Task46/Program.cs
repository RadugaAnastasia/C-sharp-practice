// Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4
// 1 4 8 19
// 5 -2 33 -2 
// 77 3 8 1

int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int minValue = Prompt("Введите число для минимального диапазона значений: ");
int maxValue = Prompt("Введите число для максимального диапазона значений: ");

int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) //GetLength(0) - длина строки
    {
        for (int j = 0; j < arr.GetLength(1); j++) //GetLength(1) - длина столбцов
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}