//  Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int [] GetRandomArray(int size, int leftRange, int rightRange)    //метод генерирует случайный массив
{
    int[] array = new int [size];
    for (int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(leftRange,rightRange+1);
    }
    return array;
}

const int size=5;                        //применяем методы
const int leftRange=-9;
const int rightRange=9;
int[]massive=GetRandomArray(size,leftRange,rightRange);


int [] newArray = new int [massive.Length];   //создаем абсолютно новый пустой массив, с длиной старого массива
for(int i=0; i<massive.Length; i++)           //копируем элементы старого массива в новый
{
    newArray[i]=massive[i];
}

Console.WriteLine(string.Join(",",massive));
Console.WriteLine(string.Join(",",newArray));
