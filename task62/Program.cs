/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */


int[,] SpiralArray(int n)
{
    int nm = 1;
    int[,] a = new int[n, n];
    for (int p = 0; p < n / 2 + 1; p++)
    {
        for (int j = p; j <= n - p - 1; j++)
            a[p, j] = nm++;
        for (int i = p + 1; i < n - p; i++)
            a[i, n - p - 1] = nm++;
        for (int j = n - p - 2; j >= p; j--)
            a[n - p - 1, j] = nm++;
        for (int i = n - p - 2; i >= p + 1; i--)
            a[i, p] = nm++;
    }
    return a;
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
Console.WriteLine("Введите величину массива: ");
if (!int.TryParse(Console.ReadLine()!, out int g))
    Console.WriteLine("Что-то пошло не так");

PrintArray(SpiralArray(g));