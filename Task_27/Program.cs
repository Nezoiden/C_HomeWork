// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

int Sum(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10; // result = result + number % 10
        number = number / 10; // number /= 10

    }
    return result;
}
int sum = Sum(num);
Console.WriteLine($"Сумма цифр числа {num} -> {sum}");



// Console.Clear();
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());

// int Sum(int number)
// {
//     if (number < 10)
//         return number;

//     int value = number % 10;
//     int nextValue = number / 10;
//     return value + Sum(nextValue);
// }

// int sum = Sum(num);
// Console.WriteLine($"Сумма цифр числа {num} -> {sum}");