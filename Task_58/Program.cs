// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixSum(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
        Console.WriteLine("Ошибка: Количество столбцов 1-й матрицы должно быть равно количеству строк 2-й матрицы!");
    else
    {
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                for (int k = 0; k < secondMatrix.GetLength(0); k++)
                {
                    resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                }
            }
        }
    }
    return resultMatrix;
}

int[,] firstMatrix = CreateMatrixRndInt(2, 2, 1, 5);
Console.WriteLine("Первая матрица:");
PrintMatrix(firstMatrix);
Console.WriteLine();

int[,] secondMatrix = CreateMatrixRndInt(2, 2, 1, 5);
Console.WriteLine("Вторая матрица:");
PrintMatrix(secondMatrix);
Console.WriteLine();

int[,] resultMatrix = MatrixSum(firstMatrix, secondMatrix);
Console.WriteLine("Произведение матриц:");
PrintMatrix(resultMatrix);