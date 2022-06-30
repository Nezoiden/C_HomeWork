// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(-num);
if (num < 100) Console.WriteLine($"У числа {num} третьей цифры нет");
else
{
    while (num > 1000) num = num / 10;
    Console.WriteLine($"Третья цифра введенного  числа: {num % 10}");
}
