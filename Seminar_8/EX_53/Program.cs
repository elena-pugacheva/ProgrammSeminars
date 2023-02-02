// // Задайте двумерный массив.  Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)   //задали массив
{
    int[,] matr = new int[rows, columns];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)         //напечатали массив
{
    for (int i = 0; i < matr.GetLength(0); i++)        //o означает кол-во строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)   //1 означает кол-во столбцов
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Change(int[,] matr)
{
    int temp = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        temp = matr[0, j];
        matr[0, j] = matr[matr.GetLength(0) - 1, j];
        matr[matr.GetLength(0) - 1, j] = temp;
    }
}

const int rows = 3;
const int columns = 4;                      //применяем методы
const int leftRange = 0;
const int rightRange = 9;

int[,] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
PrintMatrix(array);
Console.WriteLine();
Change(array);
PrintMatrix(array);
