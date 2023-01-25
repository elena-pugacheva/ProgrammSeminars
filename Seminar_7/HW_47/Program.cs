// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4. ​
// 0,5 7 -2 -0,2


double[,] FillRandomMatrix(int rows, int columns, int leftRange, int rightRange)   //задали массив
{
    double[,] matr = new double[rows, columns];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(leftRange, rightRange + 1)/10.0;
        }
    }
    return matr;
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

const int rows = 3;
const int columns = 4;
const int leftRange = -9;
const int rightRange = 9;

double[,] array = FillRandomMatrix(rows, columns, leftRange, rightRange);
PrintMatrix(array);