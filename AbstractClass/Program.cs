using AbstractClass;

class Program
{
    public static void Main(string[] args)
    {
        Car newCar = new Car(4);
        newCar.Move(30);
        newCar.SpeedUp();
    }
}
