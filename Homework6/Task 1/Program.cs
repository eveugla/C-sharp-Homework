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
/*       Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3      */
/*
int M;
int.TryParse(Console.ReadLine()!, out M);

int k = 0;

for (int i = 0; i < M; i++)
{
    int a;
    int.TryParse(Console.ReadLine()!, out a);
    if (a > 0)
        k++;
}

Console.Write($" -> {k}");
*/
/*       Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3    
45 5 2, 6, 3, 4 5 6 --9 878 -> 9  */
/*
List<string> list = new List<string>();

string user = Console.ReadLine()!;
user += " ";
string temp = "";

for (int i = 0; i < user.Length; i++)
{
    if (user[i] == '-' && IsDigit(user[i + 1]) && i < user.Length - 1)
    {
        if (temp != "")
        {
            list.Add(temp);
            temp = "-";
        }
        else
            temp = "-";
    }
    else if (IsDigit(user[i]))
    {
        temp += user[i];
    }
    else
    {
        if (temp != "")
        {
            list.Add(temp);
            temp = "";
        }
    }
}

int k = 0;

foreach (var item in list)
{
    if (int.Parse(item) > 0)
        k++;
}


foreach (var item in list)
    Console.Write($"{item} ");
Console.Write($"-> {k}");

bool IsDigit(char _ch)
{
    if (_ch >= '0' && _ch <= '9')
        return true;
    return false;
*/