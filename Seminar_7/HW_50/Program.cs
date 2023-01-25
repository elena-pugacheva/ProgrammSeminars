// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

const int rows = 3;
const int columns = 4;                      //применяем методы
const int leftRange = 0;
const int rightRange = 9;

int[,] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
PrintMatrix(array);

Console.WriteLine("Введите номер строки: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца: ");
int columnNumber = Convert.ToInt32(Console.ReadLine());

if (rowNumber < array.GetLength(0) && columnNumber < array.GetLength(1))
{
    Console.Write($"Этот элемент: {array[rowNumber, columnNumber]} ");
}
else
{
    Console.Write("Такого элемента нет");
}