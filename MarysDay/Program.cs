class MarysDay
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Good morning, Mary!");
        Console.WriteLine("This is your brain speaking.");
        Console.WriteLine("Is this day a holiday?");

        string day = Console.ReadLine();
        if (day == "No")
        {
            Console.WriteLine("You have to go to work!");
        }

        else
        {
            Console.WriteLine("Does the weather forecast show the possibility of rain?");
        }
            string weather = Console.ReadLine();

        if (weather == "Yes")
        {
            Console.WriteLine("You need to go to the shopping centre!");
        }

        else if (weather == "No")
        {
            Console.WriteLine("You need to go to the beach!");
        }
    }
}