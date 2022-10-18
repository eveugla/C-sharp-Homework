// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N.
/*
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int m, n;
Console.Write($"Введите число M: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine()!, out n);

Console.WriteLine($"Сумма элементов от {m} до {n} = {Sum(m, n)}");

int Sum(int m, int n)
{
    if (m == n)
        return n;
    return n + Sum(m, n - 1);
}
