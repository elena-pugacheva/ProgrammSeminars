// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Console.WriteLine("Введите сторону 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите сторону 2: ");
int b = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите сторону 3: ");
int c = Convert.ToInt32(Console.ReadLine());


bool Triangle(int x, int y, int z)                //метод проверки, существует ли такой треугольник. Истина или ложь(bool)
{
    if ((x + y > z) && (x + z > y) && (z + y > x))
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine(Triangle(a, b, c));