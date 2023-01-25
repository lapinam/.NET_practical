

namespace AbstractClass
{
    class Car : Transport
    {

        public Car(int wheels) : base(4) { }

        public Car() : base(4) { }


        public override void Move(int age)
        {
            if (age > 18) 
            { 
                if (moving == false)
                {
                    moving= true;
                    Console.WriteLine("The car is moving.");
                }
                else
                {
                    Console.WriteLine("The car is already moving.");
                }
            }
            else
            {
                Console.WriteLine("Can't move, because too young.");
            }
        }

        public override void SpeedUp()
        {
            if (speed < 120)
                Console.WriteLine("Car is speeding up.");
            else
                Console.WriteLine("The car speed is exceeded.");
        }
    }
}
