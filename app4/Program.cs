// division int

Console.WriteLine("Введите первое число: ");
string param_a = Console.ReadLine();

Console.WriteLine("Введите второе число: ");
string param_b = Console.ReadLine();

int result = int.Parse(param_a) / int.Parse(param_b);

Console.WriteLine($"Результат сложения = {result}");

// division double

Console.WriteLine("Введите первое число: ");
string param_c = Console.ReadLine();
double param_C = Convert.ToDouble(param_c);

Console.WriteLine("Введите второе число: ");
string param_d = Console.ReadLine();
double param_D = Convert.ToDouble(param_d);

double res = param_C / param_D;

Console.WriteLine($"Результат сложения = {res}");