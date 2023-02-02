// Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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


void RowMinElement(int[,] matr)
{
    int tempMin = 0;                                    // временная переменная(строка с мин суммой элементов)
    int minSumRow = 0;                                  // строка с мин суммой элементов
    int sumRow = 0;                                     // сумма элементов в строке
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        tempMin=tempMin+matr[0, i];                     //присваиваем значение временной строке с мин суммой элементов( обозначаем минимум)
    }
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) sumRow += matr[i, j];    //складываем элементы в каждой строке
        
        if (sumRow < tempMin)                                 // если полученная сумма меньше минимума, записываем ее с минимум и проверяем дальше
        {
            tempMin = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}

const int rows = 3;
const int columns = 5;                      //применяем методы
const int leftRange = 0;
const int rightRange = 9;

int[,] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
PrintMatrix(array);
Console.WriteLine();
RowMinElement(array);