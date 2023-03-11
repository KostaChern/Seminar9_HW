// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumNumbersFromMtoN(m, n);

void SumNumbersFromMtoN(int m, int n)
{
    Console.WriteLine();
    Console.Write($"Cумма чисел в заданном диапазоне => {SumNumbMN(m - 1, n)}");
    Console.WriteLine();
    Console.WriteLine();
}

int SumNumbMN(int m, int n)
{
    int resalt = 0;
    if (m == n) return 0;
    else
    {
        m++;
        resalt = m + SumNumbMN(m, n);
        return resalt;
    }
}
