// Работа с текстом.
// Дан текст. Нужно заменить все пробелы черточками.
// маленькие буквы "к" на большие "К",
// а маленькие "с" на большие "С".

string ReplaceText(string str, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = str.Length;
    for (int i = 0; i < length; i++)
    {
        if(str[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{str[i]}";
    }
    return result;
}

string text = "– Я думаю, – сказал князь, улыбаясь, – что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
Console.Clear();
Console.WriteLine(text);
Console.WriteLine();

string newText = ReplaceText(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

string newText2 = ReplaceText(newText, 'к', 'К');
Console.WriteLine(newText2);
Console.WriteLine();

string newText3 = ReplaceText(newText2, 'с', 'С');
Console.WriteLine(newText3);
