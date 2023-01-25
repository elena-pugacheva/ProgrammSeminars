// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// ​ (в примере подсчет индексов начинается с 1 , как в математике)
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// ​
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int[,] GetRandomMatrix (int rows, int columns)   //задали массив
{
    int [,] matrix=new int[rows,columns];

    for(int i=0; i<matrIX.GetLength(0); i++)
    {
        for (int j=0; j<matrIX.GetLength(1); j++)
        {
            matrix [i,j]= new Random(). Next (leftRange,rightRange+1);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrIX)                     
{                                                 
    for(int i=0; i<matrIX.GetLength(0); i++)        
    {
        for (int j=0; j<matrIX.GetLength(1); j++)   
        {
            Console.Write($"{matrIX[i,j]} ");
        }
    Console.WriteLine();
    }
}

void NewMatrix (int [,] matrix)
{
    for(int i=0; i<matrIX.GetLength(0); i++)
    {
        for (int j=0; j<matrIX.GetLength(1); j++)
        {
            if (i%2!=0 && j%2!=0)
            {
                matrix [i,j]=matrix[i,j]*matrix[i,j];
            }
        }
    }

}

const int rows=3;
const int columns=4;
int[,] array = GetRandomMatrix (rows, columns);
PrintMatrix(array);
NewMatrix(array);
Console.WriteLine;
PrintMatrix(array);