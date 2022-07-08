// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число которое хотите возвести в степень: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите в какую степень возвезти число: ");
int b = Convert.ToInt32(Console.ReadLine());

int Vstep(int num, int step)
{
    int result = 1;
    for (int i = 1; i <= step; i++)
    {
        result = result * num;
    }
    return result;
}
int voz = Vstep(a, b);
Console.WriteLine($"Число {a} в степени {b} -> {voz}");