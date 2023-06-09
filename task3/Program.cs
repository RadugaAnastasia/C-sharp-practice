// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер дня недели: ");
int.TryParse(Console.ReadLine(), out int result);
if (result == 1)
{
    Console.WriteLine("1 - > Понедельник ");
}
if (result == 2)
{
    Console.WriteLine("2 - > Вторник ");
}
if (result == 3)
{
    Console.WriteLine("3 - > Среда ");
}
if (result == 4)
{
    Console.WriteLine("4 - > Четверг ");
}
if (result == 5)
{
    Console.WriteLine("5 - > Пятница ");
}
if (result == 6)
{
    Console.WriteLine("6 - > Суббота ");
}
if (result == 7)
{
    Console.WriteLine("7 - > Воскресенье ");
}