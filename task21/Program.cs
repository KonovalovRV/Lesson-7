// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными 
// числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] matr = new double[3, 4];

void Fillcoll(double[,] mat,int minValue, int maxValue)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Random rnd = new Random();
            mat[i, j] = rnd.Next(minValue, maxValue)+rnd.NextDouble();
        }
    }
}

void PrintArray(double[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            System.Console.Write($"{col[i, j]:f1}   ");
        }
        System.Console.WriteLine();
    }
}

Fillcoll(matr,-10,10);

PrintArray(matr);