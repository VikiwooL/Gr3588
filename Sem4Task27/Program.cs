Console.WriteLine("введите число:");
string? num1Line = Console.ReadLine();
if(num1Line != null)
{
    int num = int.Parse(num1Line);
    int sum = 0;
    while(num>0)
    {
        sum = sum + num%10;
        num = num/10;
    }
        
        Console.Write(sum);
}