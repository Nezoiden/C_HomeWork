// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Вариант 1

// Console.Clear();
// Console.Write("Введите пятизначное число, чтобы узнать является ли оно палиндромом: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 10000 || num > 99999)
// {
//     Console.WriteLine("Введенное Вами число не пятизначное!");
//     return;
// }

// int[] array = new int[5];
// int index = 0;
// while (index <= 4)
// {
//     array[index] = num % 10;
//     num = (num - array[index]) / 10;
//     index++;
// }
// if (array[0] == array[4] && array[1] == array[3])
// {
//     Console.WriteLine("Введённое число является палиндромом!");
// }
// else
// {
//     Console.WriteLine("Введённое число не является палиндромом!!");

// }

// Вариант 2

// Console.Clear();
// Console.Write("Введите число, чтобы узнать является ли оно палиндромом: ");
// int num = Convert.ToInt32(Console.ReadLine());

// var s = num.ToString();

// if (s.Reverse().SequenceEqual(s)) Console.WriteLine($"Число {num} является палиндромом!");
// else Console.WriteLine($"Число {num} не является палиндромом!");


// Вариант 3



Console.Clear();
Console.Write("Введите число, чтобы узнать является ли оно палиндромом: ");
int num = Convert.ToInt32(Console.ReadLine());
var s = num.ToString();

for (int i = 0; i < s.Length / 2; ++i)
{
    if (s[i] != s[s.Length - 1 - i]) Console.WriteLine($"Число {s} не является палиндромом!");

    else Console.WriteLine($"Число {s} является палиндромом!");
    break;
}

