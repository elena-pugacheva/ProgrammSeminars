// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем


int[] FillRandomArray(int size)
{
    int [] array=new int[size];
    for(int i=0; i < array.Length; i++)
    {
        array[i]=new Random().Next(0,9);
    }
    return array;
}

int [] array1=FillRandomArray(8);
Console.WriteLine(string.Join(", ", array1));




