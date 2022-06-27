// Задача 8: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"{num} -> ");
bool showComa = false;
for (int i = 1; i <= num; i++)
{

    float tail = i % 2;
    if (tail == 0)
    {
        if (showComa) Console.Write(", ");
        else showComa = true;
        Console.Write($"{i}");
    }
}