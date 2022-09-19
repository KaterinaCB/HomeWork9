//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

string Numbers(int m, int n)
{
    if (m == n) return $"{n} ";
    if (m > n) return Numbers(n, m - 1) + m + " ";
    return Numbers(m, n - 1) + n + " ";
}
Console.WriteLine(Numbers(m, n));