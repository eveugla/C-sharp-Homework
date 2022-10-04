// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int a; int b; int c;

Console.Write("Введите число a: ");
int.TryParse(Console.ReadLine(), out a);

Console.Write("Введите число b: ");
int.TryParse(Console.ReadLine(), out b);

Console.Write("Введите число c: ");
int.TryParse(Console.ReadLine(), out c);

int max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine(max);

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
/*
int a, b, c;
a = new Random().Next(10);
b = new Random().Next(10);
c = new Random().Next(10);
Console.Write($"{a} {b} {c} ");

int max = a;
if (b > max)
    max = b;
if (c > max)
    max = c;
Console.Write($"\nМаксимальное число = {max}");
*/
