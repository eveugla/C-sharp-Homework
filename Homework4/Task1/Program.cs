// Задача 25: Напишите функцию, используя цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int a; int b; 
Console.Write($"Введите число A: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите число B: ");
int.TryParse(Console.ReadLine()!, out b);

int Pow(int _a, int _b)
{
    int power = 1;
    for (int i = 1; i <= _b; i++)
        power = power * a;
    return power;
}
Console.Write($"Число {a} в степени {b} = {Pow(a, b)}");