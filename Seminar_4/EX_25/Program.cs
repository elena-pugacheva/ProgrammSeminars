//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Readnumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int ToDegree(int A, int B)
{
    int result = 1;
    for (int count = 1; count <= B; count++)
    {
        result = result * A;
    }
    return result;   
}

int numberA = Readnumber("Введите число A: ");
int numberB = Readnumber("Введите число B: ");
int result1=ToDegree(numberA,numberB);
Console.WriteLine(result1);