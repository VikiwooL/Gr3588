Console.WriteLine("введите число:");
string? num1Line = Console.ReadLine();
if(num1Line != null)
{
    int num = int.Parse(num1Line);
    if(num>=1 & num<=5)
    {
      Console.WriteLine("Нет");   
    }
    else
    {
        if(num>5 & num<8)
        {
          Console.WriteLine("Да");  
        }
        else
        {
            Console.WriteLine("Нет такого дня недели");
        }
    }
}