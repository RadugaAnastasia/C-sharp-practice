// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

// ВАРИАНТ 1
using System;
class HelloWorld {
  static void Main() 
  {
      int m=10;
      int n=10;
      int [,]arr=GetArray(m,n,0,1000);
      PrintArray(arr);
      Console.WriteLine();
      var index=minindex(arr,m,n);
      int [,]res=remove(arr,m,n,index.Item1,index.Item2);
      PrintArray(res);
    
  }
  static int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max); // [0,0] , [0,1] , [0,2]....//[1,0], [1,1] , [1,2]
        }
    }
    return result;
}
   
    static
    void PrintArray(int[,] arr)
{
      for(int i = 0; i < arr.GetLength(0); i++)  // длина строки
    {
        for(int j = 0; j < arr.GetLength(1); j++)  // длина столбца
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

static int [,] remove(int[,] arr ,int m, int n, int i, int j)
{
    int [,]result = new int[m-1, n-1];
    int icorection = 0; //2 массива имеют разные размеры эта корректирует по i

    for(int k = 0; k < m; ++k)
    {
        if(i == k)
        {
            icorection = 1;
            continue; //
        }
        int jcorrection = 0; //необходимо постоянно обнулять, пока идем по строке
        for(int l = 0;l < n; ++l)
        {
            if(j == l)
            {
                jcorrection = 1; //корректирует по j
                continue;
            }
            result[k-icorection,l-jcorrection] = arr[k,l]; //результирующая корректировка
        }
    }
    return result;
}
static (int,int) minindex(int[,] arr, int m, int n)
{
    int mi = 0;
    int mj = 0;
    int min = arr[0,0];
    for(int i = 0; i < m; i++)  // длина строки
    {
        for(int j = 0; j < n; j++)  // длина столбца
        {
            if(min > arr[i,j])
            {
                min = arr[i,j];
                mi = i;
                mj = j;
            }
        }
    }
    return (mi,mj);
}
}

// ВАРИАНТ 2
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Минимальный элемент находится -> {String.Join(" ", GetIndexMinEl(array))}");
Console.WriteLine();
PrintArray(GetResultArray(array, GetIndexMinEl(array)));

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

int[] GetIndexMinEl(int[,] inArray)
{
    int[] result = new int[2];
    int min = inArray[0, 0];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (min > inArray[i, j])
            {
                min = inArray[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

int[,] GetResultArray(int[,] inArray, int[] indexes)
{
    int[,] result = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (i == indexes[0]) continue;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (j == indexes[1]) continue;
            result[row, column] = inArray[i, j];
            column++;
        }
        column = 0;
        row++;
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

// ВАРИАНТ 3
const int ROW = 4;
const int COL = 5;
const int MIN = 1;
const int MAX = 9;

int[,] matrix = GetRandomMatrix(ROW, COL, MIN, MAX);
PrintMatrix(matrix);
Console.WriteLine();
MagicMatrix(matrix);
PrintMatrix(MagicMatrix(matrix));

int[,] MagicMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int min = matrix[0, 0];
    int row = 0;
    int col = 0;

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] < min) 
            {
                min = matrix[i, j];
                row = i;
                col = j;
            }
        }
    }

    int k = 0;
    int l = 0;

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        if(i != row)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if(j != col)
                {
                    newMatrix[k, l] = matrix[i, j];
                    l++;
                }
            }   
            l = 0;    
            k++;
        }
    }

    return newMatrix;
}

int[,] GetRandomMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random random = new Random();

    for(int i = 0; i < row; i++)
        for(int j = 0; j < col; j++)
            matrix[i, j] = random.Next(min, max + 1);

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}