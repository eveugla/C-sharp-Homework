﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] array = new int[4, 4];

int n = 1;
int i = 0;
int j = 0;

while (n <= 4 * 4)
{
    array[i, j] = n;
    if (i <= j + 1 && i + j < 4 - 1)
        ++j;
    else if (i < j && i + j >= 4 - 1)
        ++i;
    else if (i >= j && i + j > 4 - 1)
        --j;
    else
        --i;
    ++n;
}

PrintArray(array);

void PrintArray(int[,] sparray)
{
    for (int i = 0; i < sparray.GetLength(0); i++)
    {
        for (int j = 0; j < sparray.GetLength(1); j++)
        {
            Console.Write(sparray[i, j] + " ");
        }
        Console.WriteLine("");
    }
}