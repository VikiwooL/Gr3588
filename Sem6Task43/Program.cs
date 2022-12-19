//  Напишите программу, которая найдёт точку пересечения двух прямых, 
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int b1 = ReadData("Введите b1: ");
int k1 = ReadData("Введите k1: ");
int b2 = ReadData("Введите b2: ");
int k2 = ReadData("Введите k2: ");
double x1 = GetX (b1,k1,b2,k2);
double y1 = GetY (b1,k1,x1);

PrintData ("Result: (" + x1 + "," + y1 + ")");

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

double GetX (int b1,int k1,int b2,int k2)
{
    return (b2-b1/k1-k2);
}

double GetY (int b1,int k1,double x1)
{
    return (k1*x1+b1);
}