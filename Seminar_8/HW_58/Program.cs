﻿// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)   // метод для первых двух матриц
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

void PrintMatrix(int[,] matr)                          //напечатать первые две матрицы
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

int[,] GetArray3(int rows, int columns, int leftRange, int array3RightRange)   //метод для третьей матрицы с изменением границ
{
    int[,] matr = new int[rows, columns];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(leftRange, array3RightRange + 1);
        }
    }
    return matr;
}


 void MultiplicationMatrix (int [,] array1, int [,] array2, int [,] array3)  //метод умножения первой матрицы на вторую
 {
     for (int i = 0; i < array3.GetLength(0); i++)
     {
         for (int j = 0; j < array3.GetLength(1); j++)
         {
             array3[i,j]=array1[i,j]*array2[i,j];
             Console.Write($"{array3[i, j]} ");
         }
         Console.WriteLine();
     }
 }

const int rows = 3;
const int columns = 5;                      
const int leftRange = 0;
const int rightRange = 3;
const int array3RightRange=10;         // граница для третьей матрицы


int[,] array1 = GetRandomMatrix(rows, columns, leftRange, rightRange);
PrintMatrix(array1);
Console.WriteLine();
int[,] array2 = GetRandomMatrix(rows, columns, leftRange, rightRange);
PrintMatrix(array2);
Console.WriteLine();
int[,] array3 = GetArray3(rows, columns, leftRange, array3RightRange);
MultiplicationMatrix(array1,array2,array3);


