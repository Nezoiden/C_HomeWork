// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели:");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1: Console.WriteLine($"{num}->нет"); break;
    case 2: Console.WriteLine($"{num}->нет"); break;
    case 3: Console.WriteLine($"{num}->нет"); break;
    case 4: Console.WriteLine($"{num}->нет"); break;
    case 5: Console.WriteLine($"{num}->нет"); break;
    case 6: Console.WriteLine($"{num}->да"); break;
    case 7: Console.WriteLine($"{num}->да"); break;
    default: Console.WriteLine($"{num}->Нет такого дня"); break;
}