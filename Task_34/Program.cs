// Задача 34: Задайте массив заполненный случайными
//  положительными трёхзначными числами. Напишите программу,
//   которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.Clear();
Console.Write("Введите длинну массива: ");
int sizeArr = int.Parse(Console.ReadLine());

int[] FillArray(int sizeArray)
{
    int[] array = new int[sizeArray];
    Random rnd = new Random();

    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

int FindEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) 
        
         count++;
                              
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("В массиве [");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}

int[] array = FillArray(sizeArr);
PrintArray(array);
 int evenNumber = FindEvenNumbers(array);
 Console.WriteLine($" колличество положительных чисел = {evenNumber}");


