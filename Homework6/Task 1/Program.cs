// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int size;
Console.WriteLine("Введите количество чисел М: ");
int.TryParse(Console.ReadLine()!, out size);

int[] n = new int[size];
FillArray(n); 
PrintArray(n);
int count = 0;

for (int i = 0; i < n.Length; i++)
if (n[i] > 0)
count++;

Console.WriteLine($"В массиве {n.Length} чисел, чисел больше нуля: {count}");

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
    for(int i = 0; i < _n.Length; i++)
    {
        Console.Write(_n[i] + " ");
    }
    Console.WriteLine();
}