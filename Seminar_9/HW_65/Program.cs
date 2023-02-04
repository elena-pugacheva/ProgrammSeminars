// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


int M = 1;
int N = 6;
int sum = 0;

void PrintNaturalNumbers(int m, int n)
{
    if (n < m) return;
    sum = sum + n;
    PrintNaturalNumbers(m, n - 1);

}

PrintNaturalNumbers(M, N);
Console.Write($"{sum} ");
