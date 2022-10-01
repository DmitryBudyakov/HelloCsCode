// числа Фибоначчи

decimal FibonacciRec(int n)
{
    // if  (n == 0 || n == 1) return 1;
    // else return Fibinacchi(n-1) + Fibinacchi(n-2);
    return (n == 0 || n == 1) ? 1 : FibonacciRec(n - 1) + FibonacciRec(n - 2);
}

for (int i = 0; i < 5; i++)
{
    // Console.WriteLine($"{i}: {FibonacciRec(i)}");
    Console.Write($"{FibonacciRec(i)} ");
}
Console.WriteLine();

