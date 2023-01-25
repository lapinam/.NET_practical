
namespace AbstractClass
{
    class Bicycle : Transport
    {

        public Bicycle(int wheels) : base(2) { }

        public Bicycle() : base(2) { }

        public override void Move(int age)
        {
            if (age > 12)
            {
                if (moving == false)
                {
                    moving = true;
                    Console.WriteLine("The bicycle is moving.");
                }
                else
                {
                    Console.WriteLine("The bicycle is already moving.");
                }
            }
            else
            {
                Console.WriteLine("Can't move, because too young.");
            }
        }

        public override void SpeedUp()
        {
            if (speed < 30)
                Console.WriteLine("Bicycle is speeding up.");
            else
                Console.WriteLine("The bicycle speed is exceeded.");
        }
    }
}

