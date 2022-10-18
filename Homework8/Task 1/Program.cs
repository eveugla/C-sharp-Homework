// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
//строки двумерного массива.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int m, n;

Console.Write($"Введите количество строк m: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write($"Введите количество столбцов n: ");
int.TryParse(Console.ReadLine()!, out n);

int[,] numbers = new int[m, n];
FillArray(numbers);
Console.WriteLine();
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < numbers.GetLength(1) - 1; k++)
        {
            if (numbers[i, k] < numbers[i, k + 1])
            {
                int temp = 0;
                temp = numbers[i, k];
                numbers[i, k] = numbers[i, k + 1];
                numbers[i, k + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
PrintArray(numbers);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
/*
for (int i = 0; i < array.GetLength(0); i++) // Переключение между строками
{
    for (int k = 0; k < array.GetLength(1) - 1; k++) // Количество повторов сортировки
    {
        int count = 0;
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (array[i, j] < array[i, j + 1])
            {
                count++;
                int temp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;
            }
        }
        if (count == 0)
            break;
    }
}
*/