void PrintArr(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length-1;i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

int[] array = new int[8];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
   array[i] = rand.Next(0,101);

PrintArr(array);