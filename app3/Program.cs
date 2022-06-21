// addition

Console.WriteLine("Введите первое число: ");
string param_a = Console.ReadLine();

Console.WriteLine("Введите второе число: ");
string param_b = Console.ReadLine();

int result = int.Parse(param_a) + int.Parse(param_b);

Console.WriteLine($"Результат сложения = {result}");