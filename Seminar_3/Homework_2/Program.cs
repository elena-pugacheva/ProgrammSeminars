// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите X1: ");
int X1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y1: ");
int Y1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Z1: ");
int Z1=Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите X2: ");
int X2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y2: ");
int Y2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Z2: ");
int Z2=Convert.ToInt32(Console.ReadLine());

int A = X2 - X1;
int B = Y2 - Y1;
int C = Z2 - Z1;

double res=Math.Sqrt(Math.Pow(A,2)+Math.Pow(B,2)+Math.Pow(C,2));
Console.WriteLine($"Расстояние между точками={res}");