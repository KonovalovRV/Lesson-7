// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int Prompt(string message)
{
    System.Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int line = Prompt("Введите количество строк матрицы   ");
int column = Prompt("Введите количество столбцов матрицы   ");
System.Console.WriteLine();

int[,] matr = new int[line, column];



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

void FindAveradgeColumn(int[,] col)
{
    for (int j = 0; j < col.GetLength(1); j++)
    {
        int count = 0;
        double result = 0;
        double sum = 0;
        for (int i = 0; i < col.GetLength(0); i++)
        {
            sum += col[i, j];
            count++;
        }
        result = sum / count;
        System.Console.Write($"Среднее арифметическое по столбцу ({j + 1}) составляет {result:f1}"
        );
        Console.WriteLine();
    }
}

Fillcoll(matr, 1, 10);

PrintArray(matr);
System.Console.WriteLine();
FindAveradgeColumn(matr);


