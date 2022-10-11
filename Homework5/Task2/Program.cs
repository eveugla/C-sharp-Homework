// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int size;
Console.WriteLine("Введите размер массива");
int.TryParse(Console.ReadLine()!, out size);

int[] n = new int[size];
FillArray(n); 
PrintArray(n);
int sum = 0;

for (int i = 0; i < n.Length; i++)
if (n[i] % 2 != 0)
    sum = sum + n[i];

Console.WriteLine($"В массиве {n.Length} чисел, сумма нечётных - {sum}");

void FillArray(int[] _n)
{
    for(int i = 0; i < _n.Length; i++)
    {
        _n[i] = new Random().Next(1,30);
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
/*      Задача 36: Задайте одномерный массив, заполненный случайными 
числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0         */
/*
int[] array = new int[new Random().Next(6, 10)];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write($"{array[i]} ");
}

int A = 0;

for (int i = 1; i < array.Length; i += 2)
    A += array[i];

Console.Write($"--> {A}");
*/