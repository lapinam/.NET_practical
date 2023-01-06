namespace AbstractClasses
{
    public abstract class Animal : IMovable, IAlive
    {
        public string Name { get; set; }

        protected int age;

        public int Age { get { return this.age; }
         set { this.age = value; } }

        public abstract void Move();

    }

    public abstract class AnotherAbstract : Animal 
    {
        //not mandatory but you can implement the abstract methods inherited from the super-class
        public override void Move()
        {
            Console.WriteLine("The method is implemented");
        }

        public abstract void AnotherAbstractMethod();
    }

    class Dog : Animal
    {
        public override void Move()
        {
            Console.WriteLine("The dog is moving");
        }
    }

    class Cat : Animal
    {
        public override void Move()
        {
            Console.WriteLine("The cat is moving");
        }
    }
}
