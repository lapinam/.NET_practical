
namespace LawyerTask
{
    class Lawyer : Person
    {
        public int LawyerId { get; set; }

        public int HelpedInCrimesSolved { get; set; }

        public Lawyer() 
        {

        }

        public Lawyer (string name, string surname, int lawyerID, int helpedInCrimesSolved) : base(name, surname)
        {
            this.LawyerId= lawyerID;
            this.HelpedInCrimesSolved= helpedInCrimesSolved;
        }

        public override string ToString()
        {
            return base.ToString() + "Lawyer ID : " + this.LawyerId + "Helped In " + this.HelpedInCrimesSolved + " solved crimes";
        }
    }
}
