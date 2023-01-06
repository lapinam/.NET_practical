
namespace LawyerTask
{
    class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public Person()
        {
            string name = "";
            string surname = "";
        }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public override string ToString()
        {
            return "Name : " + this.Name + "Surname : " + this.Surname;
        }
    }
}
