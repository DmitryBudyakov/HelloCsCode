// Задача на ветвление
// Особо поприветствовать пользователя, если его зовут Маша
Console.Write("Имя пользователя: ");
string username = Console.ReadLine().ToLower(); // все вводимые имена будут переводиться в нижний регистр

if (username == "маша")
{
    Console.WriteLine("Ура! Это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}