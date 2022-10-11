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
/*
double[] array = CreateArray(5);

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
if (array[i] > max)
max = array[i];
if (array[i]<min)
min = array[i];
}

PrintArray(array);
Console.Write($"\n{max-min}");

double[] CreateArray(int size)
{
double[] _array = new double[size];
for (int i = 0; i < size; i++)
_array[i] = new Random().Next(-8, 10);
return _array;
}

void PrintArray(double[] _array)
{
foreach (var item in _array)
Console.Write($"{item} ");
}
*/
/*      Задача 38: Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76        */
/*
double[] array = new double[new Random().Next(6, 10)];

for (int i = 0; i < array.Length; i++)
{
    array[i] = (double)new Random().Next(0, 10 * 10) / 10;
    Console.Write($"{array[i]}  ");
}

double min = array[0];
double max = array[0];

foreach (var item in array)
{
    if (min > item)
        min = item;
    if (max < item)
        max = item;
}

Console.Write($"\nmin = {min}  max = {max}  -->  {max - min}");
*/