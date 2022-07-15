// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через пробел: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int NumberUpZero(int[] array)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)

            count++;
    }
    return count;
}
NumberUpZero(arr);
int result = NumberUpZero(arr);
Console.WriteLine($"Кол-во введённых чисел больше 0 -> {result}");