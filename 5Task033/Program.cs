// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int size = Prompt("Введите размерность массива: ");
int minValue = Prompt("Введите минимальное число диапазона массива: ");
int maxValue = Prompt("Введите максимальное число диапазона массива: ");
int userNum = Prompt("Задайте искомое число: ");
int[] array = GetArray(size, minValue, maxValue);
Console.Write(userNum);
Console.Write("; ");
PrintArray(array);
Console.Write(" -> ");
GetResult(array, userNum);

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i =0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1); 
    }
    return result;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i =0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length-1]}"); //обращаемся к последнему элементу
    Console.Write("]");
}

void GetResult(int[] array, int USERNum)
{
    bool temp = false;
    for(int i =0; i < array.Length - 1; i++)
    {
        if(array[i] != USERNum)
        {
            temp = false;
        }
        else
        {
            temp = true;
        }
    }
    if(temp = true)
    {
        Console.Write("Да!");
    }
    else
    {
        Console.Write("Нет!");
    }
}