// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int m = ReadInt("Введите количество строк m: ");
int n = ReadInt("Введите количество столбцов n: ");
int[,] array = new int[m, n];
int[,] array2 = new int[m, n];
int[,] array3 = new int[m, n];

FillArray(array);
PrintArray(array);

Console.WriteLine();

FillArray(array2);
PrintArray(array2);

Console.WriteLine();

if (array.GetLength(0) != array2.GetLength(1))
{
    Console.WriteLine("Не перемножаются");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array3[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array3[i, j] += array[i, k] * array2[k, j];
        }
    }
}

PrintArray(array3);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}