// random

int param_a = new Random().Next(1,10);
Console.WriteLine($"Первое случайное число = {param_a}");

int param_b = new Random().Next(1,10);
Console.WriteLine($"Второе случайное число = {param_b}");

int result = param_a + param_b;
Console.WriteLine($"Сумма случайных чисел = {result}");