// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


Console.Clear();

Console.Write("Введите длинну массива: ");
int size = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элементов массива: ");
int max = int.Parse(Console.ReadLine());

double[] CreateArrayRndInt(int sizeArray, int minimal, int maximum)
{
    double[] array = new double[sizeArray];
    Random rnd = new Random();

    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = Math.Round(rnd.Next(minimal, maximum) + rnd.NextDouble(), 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("Разница между максимальным и минимальным элементом массива [");
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}

double MaxIndex(double[] array)
{

    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[max])

            max = i;
    }
    return array[max];
}

double MinIndex(double[] array)
{

    int min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[min])

            min = i;

    }
    return array[min];
}

double[] array = CreateArrayRndInt(size, min, max);
PrintArray(array);
double result = MaxIndex(array) - MinIndex(array);
Console.WriteLine($" = {result} ");