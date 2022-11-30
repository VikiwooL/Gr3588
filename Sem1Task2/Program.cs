Console.WriteLine("введите число:");
string? num1Line = Console.ReadLine();

if(num1Line != null)
{
    int num = int.Parse(num1Line);
    int startNum = 2;
    while (startNum<=num)
    {
        Console.Write(startNum);
        Console.Write(",");
        startNum = startNum + 2;
    }
}