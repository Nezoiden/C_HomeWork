// Задача 7: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.WriteLine("Введите трёхзначное число: ");
int num;
while (true)
{
    num = Convert.ToInt32(Console.ReadLine());
    num = Math.Abs(-num);
    if (num >= 100 && num < 1000)
    {
        break;
    }
    Console.WriteLine($"Число {num} не является трёхзначным, введите другое: ");

}
int num1 = num % 10;
Console.WriteLine($"Последняя цифра Вашего числа: {num1}");