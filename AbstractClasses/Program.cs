using AbstractClasses;

class Program
{
    public static void Main(string[] args)
    {
        Cat cat = new Cat();
        cat.Move();
        cat.Name = "Test";

        Dog dog = new Dog();
        dog.Move();
        dog.Name = "Moore";

        //this is casting (up-casting), it can be used totaly the same as in other cases
        Animal animal = cat;
        animal.Move();

        SomeMethod(cat); //this is also up-casting

        dog = (Dog)animal;//down-casting

        IMovable movable = animal;
        movable.Move();

        IAlive aliveObject = cat;
        aliveObject.Age = 13;

    }

    public static void SomeMethod(Animal obj)
    {
        obj.Move();
    }
}