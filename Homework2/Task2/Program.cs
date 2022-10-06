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
/*Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
/*
int a;
int.TryParse(Console.ReadLine()!, out a);

int temp = a;
int k = 0;
while (temp > 0)
{
    temp /= 10;
    k++;
}

if (k > 2)
    Console.Write($"{(a / (int)Math.Pow(10, k - 3)) % 10}");
else
    Console.Write($"Третьей цифры не существует");
    */

/*Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
/*
int a;
int.TryParse(Console.ReadLine()!, out a);


if (Math.Abs(a) < 100)
    Console.Write($"Третьей цифры не существует");
else
{
    int temp = a;
    while (Math.Abs(temp) >= 1000)
        temp /= 10;
    Console.Write($"{a} -> {temp % 10}");
}
*/
/*
Console.Write("Введите число: ");
    int.TryParse(Console.ReadLine()!, out a);
    if (Math.Abs(a) < 100) Console.WriteLine("Третьей цифры нет");
    else
    {
        for(;a>=1000;a/=10);
        Console.WriteLine($"Третья цифра: {a%10}");
    }
*/