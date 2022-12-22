// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number=Convert.ToInt32(Console.ReadLine());

if (number >0)

{
    if (number >=100)

    {
        while (number > 999)

        {
            number = number / 10;
        }

        int result = number % 10;
        Console.Write($"Третья цифра числа :{result}");
    }

    else

    {
        Console.Write("Третьей цифры нет!");
    }
}

else

{
    if (number <= -100)

    {
        while (number < -999)

        {
            number = number / 10;
        }

        int result = (number % 10)*(-1);
        Console.Write($"Третья цифра числа :{result}");
    }

    else
    
    {
        Console.Write("Третьей цифры нет!");
    }   
}