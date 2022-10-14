// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int m, n;

Console.Write($"Введите количество строк n: ");
int.TryParse(Console.ReadLine()!, out n);
Console.Write($"Введите количество столбцов m: ");
int.TryParse(Console.ReadLine()!, out m);

int[,] array = FillArray(n, m);
double[] sum = new double[m];
PrintArray(array);

int[,] FillArray(int n, int m)
{
    int[,] result = new int[n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = new Random().Next(-10, 10);
        }
    }
    return result;
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        sum[j] += array[i, j];
    }
}
for (int j = 0; j < m; j++)
{
    Console.Write($"{(sum[j] / n), 1} ");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
}
