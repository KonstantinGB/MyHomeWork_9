/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29  */

int Akkerman(int m, int n)
{
 if(m == 0) return n + 1;
 if(n == 0) return Akkerman(m - 1, 1);
 if(m != 0 && n != 0) return Akkerman(m - 1, Akkerman(m, n - 1));   
 return 0;
}

Console.Write($"Введите положительное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите положительное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

if(m < 0 || n < 0) Console.WriteLine("Вы ввели отрицательное число");

int akkerman = Akkerman(m, n);
Console.WriteLine($"Функция аккермана равна: {akkerman}");