class Program
{
    static void Main()
    {
        double Rectangle = CalculateArea(5.0, 7.0); // Area of a rectangle with length 5 and width 7

        double Square = CalculateArea(8.0); // Area of a square with side length 8


        Console.WriteLine($"Area of the Rectangle: {Rectangle}");
        Console.WriteLine($"Area of the Square: {Square}");

    }


    // Calculating the area of a Rectangle
    static double CalculateArea(double l, double w)
    {
        return l * w;
    }

    // Calculating the area of a Square
    static double CalculateArea(double sl)
    {
        return sl * sl;
    }

}