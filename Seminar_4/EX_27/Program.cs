// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Readnumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int a)
{
    int sum=0;

    while (a!=0)
    {
        sum=sum+a%10;
        a=a/10;
    }
    return sum;
}

int number = Readnumber("Введите число: ");
int SumAllNumbers=SumNumbers(number);
Console.WriteLine(SumAllNumbers);