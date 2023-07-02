// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int size = Prompt("Введите размерность массива: ");
int min = Prompt("Введите минимальное значение: ");
int max = Prompt("Введите максимальное значение: ");
int[] array = GetArray(size, min, max);
Console.WriteLine(String.Join($", ", array));
ReverseArray1(array);
Console.WriteLine(String.Join($", ", array));
int[] reverseArray = ReverseArray2(array);
Console.WriteLine(String.Join($", ", reverseArray));

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}

void ReverseArray1(int[] arr)
{
    for (int i = 0; i < arr.Length/2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

// Способ 2
int[] ReverseArray2(int[] arr)
{
    int[] res = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        res[i] = arr[arr.Length - 1 - i];
    }
    return res;
}