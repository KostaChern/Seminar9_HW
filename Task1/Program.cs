// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
// все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

// 

Console.Clear();

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Четные числа в диапазоне от {m} до {n} =>");

EvenNambersFromMtoN(m, n);

int EvenNambersFromMtoN(int m, int n)
{
    if (m > n) return 0;
    else
    {
        if (m % 2 == 0)
        {
            Console.Write($"{m}, ");
        }
        m++;
        EvenNambersFromMtoN(m, n);
        return m;
    }
}
