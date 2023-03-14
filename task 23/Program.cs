// Задача 23
Console.Write("Введите число n = ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
  for (int i = 1; i <= n; i++)
    Console.Write($" {Math.Pow(i, 3)}");
else if (n < 0)
  for (int i = -1; i >= n; i = --i)
    Console.Write($" {Math.Pow(i, 3)}");
else
  Console.Write("0");