/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int[,,] CreatingThreeDimensionalArray()
{
    int[,,] result = new int[2, 2, 2];
    for (int m = 0; m < result.GetLength(0); m++)
    {
        for (int i = 0; i < result.GetLength(1); i++)
        {
            for (int j = 0; j < result.GetLength(2); j++)
            {
                result[m, i, j] = new Random().Next(0, 100);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] a)
{
    for (int m = 0; m < a.GetLength(0); m++)
    {
        for (int i = 0; i < a.GetLength(1); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < a.GetLength(2); j++)
            {
                Console.Write("{0,10}", a[m, i, j] + $"({m},{i},{j})");
            }
        }
    }
    Console.WriteLine();
}
int[,,] a = CreatingThreeDimensionalArray();
PrintArray(a);