Console.WriteLine("введите трехзначное число:");
string? num1Line = Console.ReadLine();
if(num1Line != null)
{
    int num = int.Parse(num1Line);
    num = num%100;
    num = num/10;
    Console.Write(num);
}