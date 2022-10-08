//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
14212 -> нет
12821 -> да
23432 -> да
*/
int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

int a = ((N - (N % 10000)) / 10000);
int b = (N % 10000 - N % 1000) / 1000;
int c = N % 100;

if (b * 10 + a == c)
{
    Console.WriteLine($"Число {N} - палиндром!");
} 
else
{
    Console.WriteLine($"Число {N} - НЕ палиндром!");
}

/*
/*    Задача 19
Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да    */
/*
int a;
int.TryParse(Console.ReadLine()!, out a);

string str = a.ToString();

if (str[0] == str[4] && str[1] == str[3])
    Console.Write($"Число является палиндромом");
else
    Console.Write($"Число не является палиндромом");
*/
/*
int a;
int.TryParse(Console.ReadLine()!, out a);

if (a % 10 == a / 10000 && a / 10 % 10 == a / 1000 % 10)
    Console.Write($"Число является палиндромом");
else
    Console.Write($"Число не является палиндромом");
*/