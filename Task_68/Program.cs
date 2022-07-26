// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

Console.Write("Введите первое неотрицательное число: ");
int num = int.Parse(Console.ReadLine());

Console.Write("Введите второе неотрицательное число: ");
int num1 = int.Parse(Console.ReadLine());

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ackermann(m - 1, n = 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}

int functionAkkerman = Ackermann(num, num1);

Console.Write($"m = {num}, n = {num1} -> A(m,n) = {functionAkkerman} ");