// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//   значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите значения: ");
Console.Write("b1 = ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("k1 = ");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значения: ");
Console.Write("b2 = ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("k2 = ");
double k2 = double.Parse(Console.ReadLine());

void IntersectionPoint(double B1, double K1, double B2, double K2)
{

    double x = (B2 - B1) / (K1 - K2);
    double y = K1 * x + B1;
    x = Math.Round(x, 3);
    y = Math.Round(y, 3);
    if (K1 == K2)

        Console.WriteLine("Прямые параллейны и не имеют точек пересечения");
    else
        Console.WriteLine($"Точка пересечения двух прямых: ({x};{y})");
}

IntersectionPoint(b1, k1, b2, k2);