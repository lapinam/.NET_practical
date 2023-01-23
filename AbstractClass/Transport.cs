

namespace AbstractClass
{
    abstract class Transport
    {
        protected int wheels;
        protected bool moving;
        protected int speed;

        public Transport(int wheels)
        {
            this.wheels = wheels;
            this.moving = false;
            this.speed = 0;
        }

        public abstract void Move(int age);

        public abstract void SpeedUp();

        public void SpeedDown() 
        {
            if (speed !=0)
            {
                speed -= 10;
            }
            else if (speed == 0)
            {
                moving = false;
            }
        }

        public override string ToString()
        {
            return "Object type :" + this.wheels + "Is object moving :" + this.moving + "Current speed :" + this.speed;
        }
    }
}
