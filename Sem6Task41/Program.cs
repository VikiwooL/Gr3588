// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int CountNum = ReadData("Введите количество цифр: ");
int CountPosNum = CountPos(CountNum);

PrintData ("Result: " + CountPosNum);

//Выводим сообщение и получаем переменную
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Выводим сообщение
void PrintData(string res)
{
    Console.WriteLine(res);
}

//Подсчет положительных цифр
int CountPos(int num)
{
    int res=0;
    while (num > 0)
    {
        if(ReadData("Введите цифру: ")>0) res++; 
        num=num-1;
    }
    return res;
}