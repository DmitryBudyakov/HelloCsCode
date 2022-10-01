// Собрать строку с числами от a до b, a <= b

string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

// Собрать строку с числами от a до b, a >= b
string NumbersReverseRec(int a, int b)
{
    if (a <= b) return NumbersReverseRec(a + 1, b) + $"{a} ";
    else return String.Empty;
}

Console.WriteLine(NumbersRec(1, 10));
Console.WriteLine(NumbersReverseRec(1, 10));
