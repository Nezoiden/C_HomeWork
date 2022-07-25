// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

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


int[] SumColumnlNumbers(int[,] arr)
{
    int[] result = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        result[i] = sum;
    }
    return result;
}

int SearchMin(int[] arr)
{
    int minPositioin = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < arr[minPositioin])
        {
            minPositioin = i;
        }
    }
    return minPositioin + 1;
}



void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("Сумма чисел каждой строки: ");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",  ");
        else Console.Write(arr[i] + ".");
    }
    Console.WriteLine("\b");
}


int[,] arrayResult = CreateMatrixRndInt(4, 3, 1, 100);
PrintMatrix(arrayResult);
Console.WriteLine();
int[] sumArrCol = SumColumnlNumbers(arrayResult);
PrintArray(sumArrCol);

int minNumberLineMatrix = SearchMin(sumArrCol);
Console.WriteLine($"Строка с наименьшей суммой элементов: {minNumberLineMatrix} строка");






