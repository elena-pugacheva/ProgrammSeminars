// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number=Convert.ToInt32(Console.ReadLine());

 if (number<0)
    {
        number=number*(-1);
    }
    
if (number>9999 & number<100000)
{
    if (number/10000==number%10 && (number/1000)%10==(number%100)/10)
    {
        Console.Write("Палиндром.");
    }
    else
    {
        Console.Write("Не палиндром.");
    }
}
else
{
    Console.Write("Неверное число");
}

