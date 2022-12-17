///Задайте массив заполненный случайными положительными трёхзначными числами. 
///Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = GenArray(15,100,999);
PrintArray(array);
Console.WriteLine();
int result = CountEven(array);
Console.WriteLine(result);

int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] outArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = rnd.Next(minValue, maxValue);
    }
    return outArray;
}

void PrintArray(int[] arr) 
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

int CountEven(int[] array1)
{
    int Count=0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i]%2==0) 
        {
            Count=Count+1;
        }
    }
    return Count;
}