// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите число M: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int num1 = Convert.ToInt32(Console.ReadLine());



int SumNaturElements(int number, int number1)
{
    if (number == number1) return number;
    else
    if (number < number1) return number + SumNaturElements(number + 1, number1);
    else
        return number + SumNaturElements(number - 1, number1);

}

void PrintSum(int result)
{
    Console.Write($"Сумма элементов в промежутке от {num} до {num1} -> {result}");
}
int sum = SumNaturElements(num, num1);
PrintSum(sum);