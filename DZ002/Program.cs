//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Summa(int m, int n)
{
    if (m == n) return m;
    if (m > n) return m + Summa(n, m - 1);
    return n + Summa(m, n - 1);
}
Console.WriteLine(Summa(m, n));