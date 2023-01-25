// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write ("Введите десятичное число: ");
int printedNumber=Convert.ToInt32(Console.ReadLine());



int ChangeToBinary( int printedNumber)
{
    string  binaryNumber =  " ";
    while (printedNumber!=0)
    {
        binaryNumber=(printedNumber%2)+binaryNumber;
        printedNumber=printedNumber/2;
    }
    int binaryNumber2=Convert.ToInt32(binaryNumber);

    return binaryNumber2;
}


int result=ChangeToBinary(printedNumber);
Console.Write ($"{result}");