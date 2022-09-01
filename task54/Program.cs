/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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

int[,] SortingRowsDescendingOrder(int[,] a)
{
    for (var i = 0; i < a.GetLength(0); i++)
        //сортировка пузырьком
        for (var j = 0; j < a.GetLength(1); j++)
            for (var k = 0; k < a.GetLength(1); k++)
            {
                if (a[i, j] <= a[i, k]) continue;
                var temp = a[i, j];
                a[i, j] = a[i, k];
                a[i, k] = temp;
            }

    for (var i = 0; i < a.GetLength(0); i++, Console.WriteLine())
        for (var j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0,3}", a[i, j]);
        }
    //Console.Read();
    return a;
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
SortingRowsDescendingOrder(array);
