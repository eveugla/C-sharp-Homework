//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
452 -> 11
82 -> 10
9012 -> 12
*/
int a;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

int sum = 0;

while (a > 0)
{
    sum = sum + a % 10;
    a /= 10;
}
Console.Write($"Сумма равна {sum}");
/*     Задача 27: Напишите программу, 
которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12            */
/*
int a;
int.TryParse(Console.ReadLine()!, out a);

Console.Write($"{pow(a)}");

int pow(int _a)
{
    int ans = 0;
    int temp = _a;
    while (temp > 0)
    {
        ans += temp % 10;
        temp /= 10;
    }
    return ans;
}
*/