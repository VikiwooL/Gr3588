Console.WriteLine("введите число:");
string? num1Line = Console.ReadLine();
if(num1Line != null)
{
    int num = int.Parse(num1Line);
    if(num>=100)
    {
        while(num>=1000)
        {
            num = num/10;
        }
        num = num%10;
        Console.Write(num);
    }
    else
    {
       Console.WriteLine("Третьей цифры нет"); 
    }
    
}
