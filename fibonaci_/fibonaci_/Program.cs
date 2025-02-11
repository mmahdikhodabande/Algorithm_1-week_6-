


static long Fibonacci(int n)
{
    if (n < 0)
        throw new ArgumentException("n must be a non-negative integer.");

    if (n == 0) return 0;
    if (n == 1) return 1;

    long a = 0, b = 1, temp;

    for (int i = 2; i <= n; i++)
    {
        temp = a + b;
        a = b;
        b = temp;
    }

    return b;
}


Console.Write("Enter num: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Fibonacci({num}) = {Fibonacci(num)}");


