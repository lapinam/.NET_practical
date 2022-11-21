class Algorithm1
{
    public static void Main(string[] args)
    {
        //Create and algorithm how to find out which is larger 2^3 or 3^2
        Console.WriteLine("Is 2^3 larger than 3^2?");
        double number1 = Math.Pow(2, 3);
        double number2 = Math.Pow(3, 2);

        if (number1 > number2)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}