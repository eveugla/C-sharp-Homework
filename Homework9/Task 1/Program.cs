//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
//промежутке от N до 1. Выполнить с помощью рекурсии.
/*
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int N;

Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);
Numbers(N);

int Numbers(int a)
{
    Console.Write($"{a} ");
    if(a == 1) return a = 1;
    if(a < 1) return a = 0;
    else return Numbers(a - 1);
}

