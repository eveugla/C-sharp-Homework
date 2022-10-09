// Задача 29: Напишите функцию, которая задаёт массив из 8 элементов и выводит их на экран.
/*
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
void FillArray(int[] array)
{
    int i = 0;
    while (i < 8)
    {
        Console.Write($"Введите число {i}: ");
         array[i] =  int.Parse(Console.ReadLine());
        i++;
    }
}

void PrintArray(int[] amount)
{
    int pos = 0;
    while (pos < 8)
    {
        if (pos == 0)
        {
            Console.Write("[" + amount[pos] + ", ");
        }
        else if (pos == 7)
        {
            Console.Write(amount[pos] + "]");
        }
        else
        {
            Console.Write(amount[pos] + ", ");
        }
        pos++;
    }
}

int[] array = new int [8];


FillArray(array);
PrintArray(array);