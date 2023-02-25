Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "булат")
{
    Console.WriteLine("Ура, это же Булат!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}