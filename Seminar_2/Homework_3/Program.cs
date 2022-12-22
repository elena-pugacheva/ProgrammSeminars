// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру от 1 до 7: ");
int number=Convert.ToInt32(Console.ReadLine());

if (number>0 && number<8)
{
    if (number==6 || number==7)
    {
        Console.WriteLine("Это выходной.");
    }
    else
    {
        Console.WriteLine("Это будний день.");
    }
}
else
{
    Console.WriteLine("Вы ввели неверную цифру! введите цифру от 1 до 7.");
}