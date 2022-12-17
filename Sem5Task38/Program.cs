///Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = GenArray(10,-99,99);
PrintArray(array);
Console.WriteLine();
double result = MaxNum(array)-MinNum(array);
Console.WriteLine(result);

double[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    double[] outArray = new double[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = rnd.Next(minValue*1000, maxValue*1000)*0.001;
    }
    return outArray;
}

void PrintArray(double[] arr) 
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

double MaxNum(double[] array1)
{
    double max = array1[0];
    for (int i = 1; i < array1.Length; i++)
    {
        if (array1[i]>max)
        {
            max = array1[i];
        }
    }
    return max;
}

double MinNum(double[] array1)
{
    double min = array1[0];
    for (int i = 1; i < array1.Length; i++)
    {
        if (array1[i]<min)
        {
            min = array1[i];
        }
    }
    return min;
}


