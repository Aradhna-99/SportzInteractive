class Program
{
    static void Main()
    {
        // Change the value of 'n' to get the Nth Fibonacci number
        int n = 20;

        int result = Fibonacci(n);

        Console.WriteLine($"The {n}th Fibonacci number is: {result}");
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            int a = 0, b = 1, temp = 0;

            for (int i = 2; i <= n; i++)
            {
                temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }
    }
}