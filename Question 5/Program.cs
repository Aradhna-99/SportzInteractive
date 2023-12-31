public sealed class Circle
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double Calculate(Func<double, double> op)
    {
        return op(radius);
    }
}

class Program
{
    static void Main()
    {
        Circle C = new Circle(7.5);

        //  using a lambda function(function-valued parameters)
        double circumference = C.Calculate(r => 2 * Math.PI * r);

        Console.WriteLine($"The circumference of the circle is: {circumference}");
    }
}