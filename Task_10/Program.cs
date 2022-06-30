﻿// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


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
int num1 = num / 10 % 10;
Console.WriteLine($"Вторая цифра Вашего числа: {num1}");