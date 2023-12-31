class Program
{
    static void Main()
    {
        int num1 = 2;
        int num2 = 7;

        Console.WriteLine($"Before swapping  : number1 = {num1}, number2 = {num2}");

        // Swap without using a temp variable
        num1 = num1 + num2;
        num2 = num1 - num2;
        num1 = num1 - num2;

        Console.WriteLine($"After swapping  : number1 = {num1}, number2 = {num2}");
    }
}