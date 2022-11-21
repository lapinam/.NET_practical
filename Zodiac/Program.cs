class Zodiac
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your birth month:");
        int birthMonth = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter your birth day:");
        int birthDay = Int32.Parse(Console.ReadLine());

        if (birthMonth == 3 && birthDay >= 21)
        {
            Console.WriteLine("You're an Aries");
        }
        else if (birthMonth == 3 && birthDay <=21)
        {
            Console.WriteLine("You're a Pisces");
        }
    }
}