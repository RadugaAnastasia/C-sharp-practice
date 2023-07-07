// Задача 51:
// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int minValue = Prompt("Введите число для минимального диапазона значений: ");
int maxValue = Prompt("Введите число для максимального диапазона значений: ");
int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
int sum = FindSumDiagonal(array);
Console.WriteLine($"Сумма элементов главной диагонали = {sum}");

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

int FindSumDiagonal(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += arr[i,j];
            }
        }
    }
    return sum;
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