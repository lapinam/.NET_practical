class Zodiac
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your birth month (number from 1 to 12):");
        int birthMonth = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter your birth day (number from 1 to 31):");
        int birthDay = Int32.Parse(Console.ReadLine());

        if ((birthMonth == 0) || (birthMonth > 12) || (birthDay == 0) || (birthMonth == 1 && birthDay >31) || (birthMonth == 2 && birthDay > 29) || (birthMonth == 3 && birthDay > 31) || (birthMonth == 4 && birthDay > 30) || (birthMonth == 5 && birthDay > 31) || (birthMonth == 6 && birthDay > 30) || (birthMonth == 7 && birthDay > 31) || (birthMonth == 8 && birthDay > 31) || (birthMonth == 9 && birthDay > 30) || (birthMonth == 10 && birthDay > 31) || (birthMonth == 11 && birthDay > 30) || (birthMonth == 12 && birthDay > 31))
        {
            Console.WriteLine("Input is invalid");
        }
        else if ((birthMonth == 3 && birthDay >= 21) || (birthMonth == 4 && birthDay <=19))
        {
            Console.WriteLine("You're an Aries");
        }
        else if ((birthMonth == 4 && birthDay >= 20) || (birthMonth == 5 && birthDay <= 20))
        {
            Console.WriteLine("You're a Taurus");
        }
        else if ((birthMonth == 5 && birthDay >= 21) || (birthMonth == 6 && birthDay <= 21))
        {
            Console.WriteLine("You're a Gemini");
        }
        else if ((birthMonth == 6 && birthDay >= 22) || (birthMonth == 7 && birthDay <= 22))
        {
            Console.WriteLine("You're a Cancer");
        }
        else if ((birthMonth == 7 && birthDay >= 23) || (birthMonth == 8 && birthDay <= 22))
        {
            Console.WriteLine("You're a Lion");
        }
        else if ((birthMonth == 8 && birthDay >= 23) || (birthMonth == 9 && birthDay <= 22))
        {
            Console.WriteLine("You're a Virgo");
        }
        else if ((birthMonth == 9 && birthDay >= 23) || (birthMonth == 10 && birthDay <= 23))
        {
            Console.WriteLine("You're a Libra");
        }
        else if ((birthMonth == 10 && birthDay >= 24) || (birthMonth == 11 && birthDay <= 21))
        {
            Console.WriteLine("You're a Scorpius");
        }
        else if ((birthMonth == 11 && birthDay >= 22) || (birthMonth == 12 && birthDay <= 21))
        {
            Console.WriteLine("You're a Sagittarius");
        }
        else if ((birthMonth == 12 && birthDay >= 22) || (birthMonth == 1 && birthDay <= 19))
        {
            Console.WriteLine("You're a Capricornus");
        }
        else if ((birthMonth == 1 && birthDay >= 20) || (birthMonth == 2 && birthDay <= 18))
        {
            Console.WriteLine("You're an Aquarius");
        }
        else if ((birthMonth == 2 && birthDay >= 20) || (birthMonth == 3 && birthDay <= 20))
        {
            Console.WriteLine("You're a Piscies");
        }
    }
}