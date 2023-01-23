using Interfaces;

class Program
{

    public static void Main(string[] args)
    {
        Triangle bob = new Triangle(2,3,4,8);
        Console.WriteLine("Triangle perimeter is: " + bob.CalculatePerimeter());
        Console.WriteLine("Triangle area is: " + bob.CalculateArea());

        Rectangle orange = new Rectangle();
        orange.Edge1 = 78;
        orange.Edge2 = 659;
        Console.WriteLine("Rectangle perimeter is: " + orange.CalculatePerimeter());
        Console.WriteLine("Rectangle area is: " + orange.CalculateArea());


        Circle astrolopiteks = new Circle();
        Console.WriteLine("Enter radius: ");
        astrolopiteks.Radius = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Circle perimeter is: " + astrolopiteks.CalculatePerimeter());
        Console.WriteLine("Circle area is: " + astrolopiteks.CalculateArea());
    }


}
