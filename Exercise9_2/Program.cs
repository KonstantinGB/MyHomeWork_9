/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SumMN(int m, int n)
{
 if(m < n) return m + SumMN(m + 1, n);
 if(m > n) return m + SumMN(m - 1, n);
 return n;
}

Console.Write($"Введите первое число(m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите второе число(n): ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = SumMN(m, n);
Console.WriteLine($"Сумма элементов от {m} до {n} = {sum}");
