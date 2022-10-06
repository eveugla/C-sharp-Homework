//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
string NIndex = N.ToString();

if (NIndex.Length > 2)
{
    Console.Write($"Третья цифра числа - {NIndex[2]}");
}
else
{
    Console.Write("Третьей цифры нет");
}