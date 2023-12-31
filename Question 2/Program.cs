class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine("valar");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("morghulis");
            }
            else if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("valar morghulis");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}