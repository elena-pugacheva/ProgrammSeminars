// Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

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

void Count(int[,] matr)
{
    for (int temp = 0; temp <= 9; temp++)
    {
        int count = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (matr[i, j] == temp)
                {
                    count+=1;
                }
            }
        }
        Console.WriteLine($"{temp} встречается {count} раз.");
    }
    
}


const int rows = 3;
const int columns = 4;                      //применяем методы
const int leftRange = 0;
const int rightRange = 9;

int[,] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
PrintMatrix(array);
Console.WriteLine();
Count(array);
