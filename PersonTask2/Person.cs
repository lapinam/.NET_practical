
namespace PersonTask2
{
    class Person
    {
        private string name;
        private string surname;
        private Date dateOfBirth;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Surname
        {
            get { return this.surname; }
            set { this.surname = value; }
        }

        public Date DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }

        public Person()
        {
            this.name = "";
            this.surname = "";
            this.dateOfBirth = new Date("01.01.2000.");
        }


    public string GetFullName
        {
            get { return name + " " + surname; }
        }

        public string CalculateFullName()
        {
            return name + " " + surname;
        }


        public void ShowPerson()
        {
            Console.WriteLine("Your full name is:" + this.GetFullName);
            Console.WriteLine("Your age is:" + this.GetCurrentAge());
        }
    }
}
