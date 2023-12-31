class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the base number: ");
        double baseNumber = double.Parse(s: Console.ReadLine());

        Console.WriteLine("Enter the exponent: ");
        int exponent = int.Parse(s: Console.ReadLine());

        double result = Power(baseNumber, exponent);

        Console.WriteLine($"{baseNumber} raised to the power of {exponent} is: {result}");
    }

    static double Power(double baseNumber, int exponent)
    {
        return PowerTailRecursive(baseNumber, exponent, 1);
    }

    static double PowerTailRecursive(double baseNumber, int exponent, double result)
    {
        if (exponent == 0)
        {
            return result;
        }

        return PowerTailRecursive(baseNumber, exponent - 1, result * baseNumber);
    }
}