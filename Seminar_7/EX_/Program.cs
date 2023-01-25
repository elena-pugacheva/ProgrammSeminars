// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] GetRandomMatrix(int rows, int columns,int leftRange, int rightRange)   //задали массив
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumNumbers (int [,] matrix)
{
    int sum=0;

    //for (int i=0; i<matrix.GetLength(0); && i<matrix.GetLength(1); i++)   - //с помощью одного цикла
    // {
            // sum=sum +matrix[i,i];
    // }
        //return sum;


    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            if (i==j)
            {
                sum=sum + matrix[i,j];
            }
        }
    }
    return sum;
}

const int rows=3;
const int columns=4;
const int leftRange=1;
const int rightRange=9;

int[,] array = GetRandomMatrix (rows, columns,leftRange, rightRange);
PrintArray(array);
Console.WriteLine(SumNumbers(array));

