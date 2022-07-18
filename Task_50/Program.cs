// Задача 50. Напишите программу, которая на вход принимает позиции
//  элемента в двумерном массиве, и возвращает значение этого элемента
//   или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Clear();

Console.Write("Введите номер строки:");
int line = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца:");
int column = int.Parse(Console.ReadLine());

void ElementSearch(int[,] array, int lineNumber, int columnNumber)
{
    int i = (lineNumber - 1);
    int j = (columnNumber - 1);
    if (i > array.GetLength(0) || i < 0 || j > array.GetLength(1) || j < 0)

        Console.WriteLine("В заданной позиции элементов нет!");

    else Console.WriteLine($"Число в заданной позиции -> {array[(lineNumber - 1), (columnNumber - 1)]}");
}


int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} | ");
            else Console.Write($"{arr[i, j],3} ] ");
        }
        Console.WriteLine();
    }
}

int[,] arrayResult = CreateMatrixRndInt(3, 4, 1, 100);
PrintMatrix(arrayResult);
Console.WriteLine();
ElementSearch(arrayResult, line, column);