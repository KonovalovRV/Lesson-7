// Задача 2. Напишите программу, которая на вход принимает позиции элемента в
// двумерном массиве, и возвращает значение этого элемента или же указание,
//  что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет


int[,] matr = new int[3, 4];


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
                Console.Write($"{col[i, j]}   ");
            }
            Console.WriteLine();
        }
    }
    
int Prompt(string message)
{
 Console.WriteLine(message);
int value = Convert.ToInt32(Console.ReadLine());
return value;
}
void ValidatePositionMatrix(int[,] coll, int arg, int arg1)
{
int value = 0;
int value1 = 0;
for (int i = 0; i < coll.GetLength(0); i++)
{
if (i == arg)
{
for (int j = 0; j < coll.GetLength(1); j++)
{
if (j == arg1)
{
value1 = arg1;
}
else
{

Console.WriteLine($"{value}, {value1}");
}
Console.WriteLine("Такого числа в массиве нет");
}

