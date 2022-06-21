// if-else

Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();
string user = username.ToLower();

if(user == "мария")
{
    Console.WriteLine("Привет Машуня!");
}
else
{
    Console.WriteLine($"Ты зачем пришел {user}");
}