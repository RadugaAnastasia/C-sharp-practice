// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12 -> 2
// 85 -> 8

Console.Clear(); //для автоматической очистки терминала
int number = new Random().Next(10, 100);  //будет генерировать положительное число от 0, сколько вмещает int
int firstValue = number/10; //проверяем делится ли на цело на 10
int secondValue = number%10; //берем остаток от деления на 10
Console.WriteLine(number + " " + firstValue + " " + secondValue);
if(firstValue > secondValue)
{
    Console.WriteLine(firstValue);
}
else if(firstValue == secondValue)
{
    Console.WriteLine("цифры числа равны");
}
else
{
    Console.WriteLine(secondValue);
}