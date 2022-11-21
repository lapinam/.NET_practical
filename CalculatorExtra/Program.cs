Console.WriteLine("Enter number 1:");
string input1 = Console.ReadLine();
Console.WriteLine("Enter number 2:");
string input2 = Console.ReadLine();
Console.WriteLine("Choose the math operation:");
Console.WriteLine("+ for addition, - for substraction, * for multiplication, / for division or % for modulo.");
string input3 = Console.ReadLine();

double number1 = double.Parse(input1);
double number2 = double.Parse(input2);

if (input3 == "+")
{
    double sum1 = number1 + number2;
    Console.WriteLine(sum1);
}
else if (input3 == "-")
{
    double sub1 = number1 - number2;
    Console.WriteLine(sub1);
}
else if (input3 == "*")
{
    double mult1 = number1 * number2;
    Console.WriteLine(mult1);
}
else if (input3 == "/")
{
    double div1 = number1 / number2;
    Console.WriteLine(div1);
}
else if (input3 == "%")
{
    double mod1 = number1 % number2;
    Console.WriteLine(mod1);
}

if (number2 == 0 && input3 == "/")
{
    Console.WriteLine("The input is not valid!");
}
