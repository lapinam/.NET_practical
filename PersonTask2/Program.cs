namespace PersonTask2
{
    class PersonProject
    {
        public static void Main(string[] args)
        {
            Person newPerson = new Person();
            Console.WriteLine("Enter your name:");
            newPerson.Name = Console.ReadLine();

            Console.WriteLine("Enter your surname:");
            newPerson.Surname = Console.ReadLine();

            Console.WriteLine("Enter your date of birth: (dd.mm.yyyy");
            string value1 = Console.ReadLine();
            Date date = new Date(value1);
            newPerson.DateOfBirth = date;

            newPerson.ShowPerson();

            


        }
    }
}