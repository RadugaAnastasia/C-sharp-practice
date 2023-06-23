// Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int size = Prompt("Введите размерность массива: ");
int minValue = Prompt("Введите минимальное число диапазона массива: ");
int maxValue = Prompt("Введите максимальное число диапазона массива: ");
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
Console.Write(" -> ");
GetResult(array);

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

void GetResult(int[] array)
{
    Console.Write("[");
    for(int i =0; i < array.Length - 1; i++)
    {
    Console.Write($"{array[i] * (-1)},  ");
    }
    Console.Write($"{array[array.Length-1]}"); //обращаемся к последнему элементу
    Console.Write("]");
}