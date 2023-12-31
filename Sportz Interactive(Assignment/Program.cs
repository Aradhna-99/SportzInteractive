class Program
{
    static void Main()
    {
        int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int Evens = SumEvenNumbers(num);

        Console.WriteLine("Sum of even numbers: " + Evens);
    }

    static int SumEvenNumbers(int[] numbers)
    {
        int sum = 0;

        foreach (var n in numbers)
        {
            if (n % 2 == 0)
            {
                sum += n;
            }
        }

        return sum;
    }
}