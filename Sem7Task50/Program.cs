// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] array2D = Fill2DArray(5, 6, -100, 100);
Print2DArray(array2D);

int numRow = ReadData("Введите номер строки: ");
int numColumn = ReadData("Введите номер столбца: ");

WriteItem(array2D, numRow, numColumn);

// Универсальный метод генерации и заполнение двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder);
        }
    }
    return array2D;
}

//Вывод в консоль элементы массива
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Чтение данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Вывод заданного эелемента
void WriteItem(int[,] array2D, int numRow, int numColumn)
{
    if(numRow<array2D.GetLength(0) & numColumn<array2D.GetLength(1))
    {
        Console.WriteLine(array2D[numRow-1, numColumn-1]);
    }
    else
    {
        Console.WriteLine("такой позиции нет");
    }
}