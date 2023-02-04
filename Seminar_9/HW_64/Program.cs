// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



void PrintNumber(int n, int m)
{

    if (m > n) return;
    PrintNumber(n, m + 1);
    Console.Write($"{m} ");

}
int M = 1;
int number = 5;
PrintNumber(number, M);




