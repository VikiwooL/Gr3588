Console.WriteLine("введите три числа:");
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();
string? num3Line = Console.ReadLine();

if(num1Line != null && num2Line != null && num3Line != null)
{
    int[] num = new int[3];
    num[0] = int.Parse(num1Line);
    num[1] = int.Parse(num2Line);
    num[2] = int.Parse(num3Line);

    int startNum = 1;
    int endNum = 3;
    int max = num[0];
    while (startNum<endNum)
    {
        if (num[startNum]>max)
        {
            max = num[startNum];
        }
        startNum++;
    }

    Console.Write("max=");
    Console.WriteLine(max);
}