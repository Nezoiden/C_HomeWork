// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();

int[,] CreateMatrixRndInt(int m, int n, int minimum, int maximum)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(minimum, maximum + 1);
        }
    }
    return arr;
}


void SearchAverage(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double average = 0;

        for (int i = 0; i < array.GetLength(0); i++)

            average += array[i, j];
        average = Math.Round(average / array.GetLength(1), 1);
        Console.WriteLine($"Cреднее арифметическое элементов столбца {j + 1} = {average}");

    }

}


void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} |");
            else Console.Write($"{arr[i, j],3} ]");
        }
        Console.WriteLine();
    }
}

int[,] arrayResult = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(arrayResult);
SearchAverage(arrayResult);
