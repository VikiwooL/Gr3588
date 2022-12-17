///Задайте одномерный массив, заполненный случайными числами. 
///Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = GenArray(10,-99,99);
PrintArray(array);
Console.WriteLine();
int result = SumNum(array);
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

int SumNum(int[] array1)
{
    int Sum=0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i]%2!=0) 
        {
            Sum=array1[i]+Sum;
        }
    }
    return Sum;
}