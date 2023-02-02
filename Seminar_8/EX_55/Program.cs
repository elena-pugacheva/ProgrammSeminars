// Задайте двумерный массив. 
//Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] Change(int[,] matr)
{
    int[,] matr2 = new int[matr.GetLength(1), matr.GetLength(0)];
    for (int i = 0; i < matr2.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            matr2[i, j] = matr[j, i];
        }
    }
    return matr2;
}

const int rows = 3;
const int columns = 5;                      //применяем методы
const int leftRange = 0;
const int rightRange = 9;

int[,] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
PrintMatrix(array);
Console.WriteLine();
int[,] matr2 = Change(array);
PrintMatrix(matr2);