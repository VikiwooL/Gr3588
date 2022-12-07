Console.WriteLine("введите пятизначное число:");
string? num1Line = Console.ReadLine();
int[] array = new int[5];
if(num1Line != null)
{
    int num = int.Parse(num1Line);
    int endIndex=5;
    int startIndex=0;
   while (startIndex<endIndex)
    {
        array[startIndex]=num%10;
        num=num/10;
        startIndex++;
    }
       if(array[0]==array[4] & array[1]==array[3])
    {
     Console.WriteLine("Да");
    }
    else
    {
       Console.WriteLine("нет"); 
    }
}
