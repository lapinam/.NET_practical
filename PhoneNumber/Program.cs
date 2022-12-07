using System.Text.RegularExpressions;

class Lesson05122022
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter your phone number");
        string phoneNumber = Console.ReadLine();
        
        if (Regex.Match(phoneNumber, @"^(\+371){0,1}( ){0,1}[0-9]{8}$").Success)
           Console.WriteLine("Thank you!");
        else
            Console.WriteLine("This number is invalid.");

    }

}