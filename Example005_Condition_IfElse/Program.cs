// Задача на ветвление
// Особо поприветствовать пользователя, если его зовут Маша
Console.Write("Имя пользователя: ");
string username = Console.ReadLine(); 

if (username.ToLower() == "маша")   // все вводимые имена будут переводиться в нижний регистр
{
    Console.WriteLine("Ура! Это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}