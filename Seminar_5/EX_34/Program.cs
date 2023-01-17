//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] FillRandomArray(int size,int left, int right)
{
    int [] array=new int[size];
    for(int i=0; i < array.Length; i++)
    {
        array[i]=new Random().Next(left, right);
    }
    return array;
}
int size=10;
int left=100;
int right=1000;
int count=0;

int [] massive=FillRandomArray( size, left, right);
Console.WriteLine(string.Join(", ", massive));


for(int i=0; i < massive.Length; i++)
{
    if (massive[i]%2==0)

    {
        count++;
    }
}
Console.WriteLine($"{count}");
