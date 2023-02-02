// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


int[,] GetRandomMatrix (int rows, int columns, int leftRange, int rightRange)   //задали массив
{
    int [,] matr=new int[rows,columns];

    for(int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            matr [i,j]= new Random(). Next (leftRange,rightRange+1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)         //напечатали массив
{
    for(int i=0; i<matr.GetLength(0); i++)        //o означает кол-во строк
    {
        for (int j=0; j<matr.GetLength(1); j++)   //1 означает кол-во столбцов
        {
            Console.Write($"{matr[i,j]} ");
        }
    Console.WriteLine();
    }
}

const int rows=3; 
const int columns=4;                      //применяем методы
const int leftRange=0;
const int rightRange=10;

int[,] array = GetRandomMatrix (rows, columns, leftRange, rightRange);
PrintMatrix(array);



