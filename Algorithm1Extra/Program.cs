class Algorithm1Extra
{
    public static void Main(string[] args)
    {
        //Create and algorithm how to find out which is larger x^y or y^x
        Console.WriteLine("Enter number 1:");
        string input1 = Console.ReadLine();
        double num1 = Double.Parse(input1);
        Console.WriteLine("Enter number 2:");
        string input2 = Console.ReadLine();
        double num2 = Double.Parse(input2);

        Console.WriteLine("Is num1^num2 larger than num2^num1?");
        double number1 = Math.Pow(num1, num2);
        double number2 = Math.Pow(num2, num1);

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