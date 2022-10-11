// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
[345, 897, 568, 234] -> 2
*/
int size;
Console.WriteLine("Введите размер массива");
int.TryParse(Console.ReadLine()!, out size);

int[] n = new int[size];
FillArray(n); 
PrintArray(n);
int count = 0;

for (int i = 0; i < n.Length; i++)
if (n[i] % 2 == 0)
count++;

Console.WriteLine($"В массиве {n.Length} чисел, чётных - {count}");

void FillArray(int[] _n)
{
    for(int i = 0; i < _n.Length; i++)
    {
        int a;
        Console.Write($"Введите элемент[{i}]: ");
        int.TryParse(Console.ReadLine()!, out a);
        _n[i] = a;
    }
}
void PrintArray(int[] _n)
{
    Console.Write("[ ");
    for(int i = 0; i < _n.Length; i++)
    {
        Console.Write(_n[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

/*      Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2         */
/*
int[] array = new int[new Random().Next(6, 10)];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($"{array[i]} ");
}

int A = 0;

foreach (var item in array)
    if (item % 2 == 0)
        A++;

Console.Write($"-->{A}");
*/
