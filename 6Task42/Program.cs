// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// ВАРИАНТ 1 
// int TakeUserNum()
// {
//     int userNum;
//     while (!int.TryParse(Console.ReadLine(), out userNum))
//     {
//         // Console.WriteLine("Пожалуйста, введите число: ");
//     }
//     return userNum;
// }
// Console.WriteLine("Пожалуйста, введите число: ");
// int userValue = TakeUserNum();
// Console.Write($" {userValue} -> ");
// string binary = Convert.ToString(userValue, 2);
// Console.Write(binary);

// ВАРИАНТ 2

int TakeUserNum()
{
    int userNum;
    while (!int.TryParse(Console.ReadLine(), out userNum))
    {
        // Console.WriteLine("Пожалуйста, введите число: ");
    }
    return userNum;
}

string BinaryConvert(int userNum)
{
    string newValue = "";
    while (userNum >= 1)
    {
        newValue = (userNum % 2).ToString() + newValue;
        userNum /= 2;
    }
    return newValue;
}

Console.WriteLine(BinaryConvert(TakeUserNum()));
