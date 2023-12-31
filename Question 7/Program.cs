public enum Colors
{
    Red,
    Blue,
    Green,
    Yellow
}

class Program
{
    static void Main()
    {
        // Iterate through Enum values
        foreach (Colors c in Enum.GetValues(typeof(Colors)))
        {
            Console.WriteLine(c);
        }
    }
}