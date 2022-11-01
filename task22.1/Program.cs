// Задача 2. Напишите программу, которая на вход принимает позиции элемента в
// двумерном массиве, и возвращает значение этого элемента или же указание,
//  что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет


int Prompt(string message)
{
    System.Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void Fillcoll(int[,] mat, int minValue, int maxValue)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Random rnd = new Random();
            mat[i, j] = rnd.Next(minValue, maxValue);
        }
    }
}

void PrintArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            System.Console.Write($"{col[i, j]}   ");
        }
        System.Console.WriteLine();
    }
}

int FindPositionElemet(int[,] mattr, int lin, int col)
{
    int number=-1;
    for (int i = 0; i < mattr.GetLength(0); i++)
    {
        for (int j = 0; j < mattr.GetLength(1); j++)
        {
            if (i == lin && j == col)
            {
                return mattr[i, j]; 
            }
        }
    }
    return number;
}


int index1 = Prompt("Bведите номер строки    ");

int index2 = Prompt("Bведите номер столбца    ");

int[,] matr = new int[3, 4];
System.Console.WriteLine();
Fillcoll(matr, 1, 10);

PrintArray(matr);

int value=FindPositionElemet(matr, index1, index2);

if(value==-1)
{
System.Console.WriteLine("Такого элемента в массиве нет");
}
else
{
System.Console.WriteLine($"Элемент массива имеет значение --> {matr[index1, index2]}");  
}
