// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
[3 7 22 2 78] -> 76
*/
int size;
Console.WriteLine("Введите размер массива");
int.TryParse(Console.ReadLine()!, out size);

double max;
double min;

double[] n = new double[size];
FillArray(n); 
PrintArray(n);

max = n[0];
min = n[0];

for (int i = 0; i < n.Length; i++)
{
    if (n[i] > max)
        {
            max = n[i];
        }
    if (n[i] < min)
        {
            min = n[i];
        }
}

Console.WriteLine($"В массиве {n.Length} чисел");
Console.WriteLine($"Max = {max}");
Console.WriteLine($"Min = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max - min}");

void FillArray(double[] _n)
{
    for(int i = 0; i < _n.Length; i++)
        {
            _n[i] = new Random().Next(1,30);
        }
}
void PrintArray(double[] _n)
{
    Console.Write("[ ");
    for(int i = 0; i < _n.Length; i++)
        {
            Console.Write(_n[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}