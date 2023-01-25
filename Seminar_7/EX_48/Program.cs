// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] GetRandomMatrix (int rows, int columns)   //задали массив
{
    int [,] matrix=new int[rows,columns];

    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            matrix [i,j]= i+j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)         //напечатали массив
{
    for(int i=0; i<matrix.GetLength(0); i++)        //o означает кол-во строк
    {
        for (int j=0; j<matrix.GetLength(1); j++)   //1 означает кол-во столбцов
        {
            Console.Write($"{matrix[i,j]} ");
        }
    Console.WriteLine();
    }
}

const int rows=3; 
const int columns=4; 

int[,] array = GetRandomMatrix (rows, columns);
PrintMatrix(array);

