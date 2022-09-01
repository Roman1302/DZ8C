/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }

    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,3}", arr[i, j]);
        }
        Console.WriteLine();
    }
}

int[] SumLines(int[,] a)
{
    int[] sumSt = new int[a.GetLength(0)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < a.GetLength(1); j++)
        {
            sum += a[i, j];
        }
        sumSt[i] = sum;
        // Console.WriteLine($"сумма {i} {sumSt[i]}");
    }
    return sumSt;
}
void RowSmallerAmount(int[] summ)
{
    int[] massiv = summ;
    int min = massiv[0];
    int index = 0;
    for (int i = 1; i < massiv.Length; i++)
        if (min > massiv[i])
        {
            min = massiv[i];
            index = i;
        }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {index+1} строка");
}

Console.WriteLine("Введите число строк (m): ");
if (!int.TryParse(Console.ReadLine()!, out int m))
    Console.WriteLine("Что-то пошло не так");

Console.WriteLine("Введите число столбцов (n): ");
if (!int.TryParse(Console.ReadLine()!, out int n))
    Console.WriteLine("Что-то пошло не так");

Console.WriteLine();
int[,] array = CreateArrayWithRandomNumbers(m, n);
PrintArray(array);
Console.WriteLine();
SumLines(array);
RowSmallerAmount(SumLines(array));
