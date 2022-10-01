// Возведение в степень

int PowerRec(int a, int n)
{
    // if (n == 0) return 1;
    // else return a * PowerRec(a, n - 1);
    return (n == 0) ? 1 : a * PowerRec(a, n - 1);
}

int PowerRecMath(int a, int n)
{
    // return (n == 0) ? 1 : a * PowerRec(a, n - 1);
    if (n == 0) return 1;
    if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return a * PowerRecMath(a, n - 1);

}
Console.WriteLine(PowerRec(3, 3));
Console.WriteLine(PowerRecMath(3, 3));
