//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int number=Convert.ToInt32(Console.ReadLine());

if (number>0)
{
    if (number>99 & number<999)
    {
        int result=(number/10)%10;
        Console.Write($"Вторая цифра:{result}");
    }
    else
    {
        Console.Write("Вы ввели неправильное число!");
    }
        
}

else
{
    if (number<-99 & number>-999)
    {
        int result=(-1)*(number/10)%10;
        Console.Write($"Вторая цифра:{result}");
    }
    else
    {
        Console.Write("Вы ввели неправильное число!");
    }
    
}


