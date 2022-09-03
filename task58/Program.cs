/* Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] CreateArrayWithRandomNumbers()
{
    int[,] result = new int[2, 2];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0,3}", a[i, j]);
        }
    }
    Console.WriteLine();
}

void PrintArray2(int[,] a, int[,] b)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0,3}", a[i, j]);
        }
    }
    Console.WriteLine();
    for (int i = 0; i < b.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < b.GetLength(1); j++)
        {
            Console.Write("{0,3}", b[i, j]);

        }
    }
}

int[,] MatrixMultiplication(int[,] a, int[,] b)
{
    int[,] r = new int[b.GetLength(0), b.GetLength(1)];

    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int k = 0; k < a.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}

int[,] array1 =  CreateArrayWithRandomNumbers(); //new int[,] { { 2, 4 }, { 3, 2 }};
int[,] array2 = CreateArrayWithRandomNumbers(); //new int[,] { { 3, 4 }, { 3, 3 }};
PrintArray2(array1, array2);
Console.WriteLine();
PrintArray(MatrixMultiplication(array1, array2));