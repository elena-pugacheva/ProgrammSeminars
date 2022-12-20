//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите положительное число выше 1: ");
int number=Convert.ToInt32(Console.ReadLine());

int i=1;

Console.WriteLine($"Чётные числа от 1 до {number}: ");

while (i <= number)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i}, ");
        i++;
    }
    else
    {
        i++;
    }
}


