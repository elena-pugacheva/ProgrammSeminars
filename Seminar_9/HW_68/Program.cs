// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
int M=2;
int N=3;

Console.Write(AkkermanFunction(M, N));

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
  
    else if (n == 0 && m > 0) return AkkermanFunction(m - 1, 1);
   
    else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}