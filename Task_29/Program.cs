// Задача 29: Напишите программу, которая задаёт массив из 8 элементов,
//  заполненный псевдослучайными числами и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


// int[] array = new int[8];
// Random rand = new Random();
// Console.Write("[");
// for (int i = 0; i < 8; i++)
// {
//     array[i] = rand.Next(-1000, 1000);
//     Console.Write(array[i] + ",");
// }
// Console.Write("\b\b]");


Console.WriteLine("Введите длинну массива: ");
 int num = int.Parse(Console.ReadLine());

int[] FillArray(int num)
{
    int[] array = new int[num];
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(-1000, 1000);
        index++;
    }
    return array;
}

void PrintArray(int[] col)
{
    Console.Write("[");
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
    Console.Write("\b\b]");
}

int[] arr = FillArray(num);
PrintArray(arr);
