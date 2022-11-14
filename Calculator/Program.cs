class Calculator
{
    static void Main(string[] args)
    {

        Console.WriteLine("enter number:");
            string input1 = Console.ReadLine();
        Console.WriteLine("enter second number:");
            string input2 = Console.ReadLine();
        int number1 = int.Parse(input1);
        int number2 = int.Parse(input2);
        int sum1 = number1 + number2;
        int sub1 = number1 - number2;
        int mul1 = number1 * number2;
        int div1 = number1 / number2;
        Console.WriteLine("the sum of these numbers is:" + ' ' + sum1);
        Console.WriteLine("the substraction of these numbers is:" + ' ' + sub1);
        Console.WriteLine("the multiplication of these numbers is:" + ' ' + mul1);
        Console.WriteLine("the division of these numbers is:" + ' ' + div1);

    }
}
