class Calculator
{
    static void Main(string[] args)
    {

        Console.WriteLine("enter number:");
            string input1 = Console.ReadLine();
        Console.WriteLine("enter second number:");
            string input2 = Console.ReadLine();
        double number1 = Double.Parse(input1);
        double number2 = Double.Parse(input2);
        double sum1 = number1 + number2;
        double sub1 = number1 - number2;
        double mul1 = number1 * number2;
        double div1 = number1 / number2;
        Console.WriteLine("the sum of these numbers is:" + ' ' + sum1);
        Console.WriteLine("the substraction of these numbers is:" + ' ' + sub1);
        Console.WriteLine("the multiplication of these numbers is:" + ' ' + mul1);
        Console.WriteLine("the division of these numbers is:" + ' ' + div1);

    }
}
