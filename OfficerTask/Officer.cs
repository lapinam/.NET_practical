
namespace OfficerTask
{
    class Officer
    {
        private string name;
        private string surname;
        private int officerID;
        private string workingDistrict;
        private int crimesSolved;

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

        public int OfficerID
        {
            get { return this.officerID; }
            set { this.officerID = value; }
        }

        public string WorkingDistrict
        {
            get { return this.workingDistrict; }
            set { this.workingDistrict = value; }
        }

        public int CrimesSolved
        {
            get { return this.crimesSolved;}
            set { this.crimesSolved = value; }
        }

        public Officer()
        {
            this.name = "";
            this.surname = "";
            this.officerID = 0;
            this.workingDistrict = "" ;
            this.crimesSolved = 0;
        }

        public Officer(string name, string surname, int officerID, string workingDistrict, int crimesSolved)
        {
            this.Name = name;
            this.Surname = surname;
            this.OfficerID = officerID;
            this.WorkingDistrict = workingDistrict;
            this.CrimesSolved = crimesSolved;
        }

        public int CalculateLevel()
        {
            int level = 0;

            if (this.crimesSolved < 20)
                level = 1;
            else if (this.crimesSolved >= 20 && this.crimesSolved < 40)
                level = 2;
            else
                level = 3;

             return level;
        }

        public static int Level1Off(Officer[] District99)
        {
            int level1 = 0;

            for (int i = 0; i < District99.Length; i++)
            {
                if (District99[i].CalculateLevel() == 1)
                {
                    level1++;
                }
            }
            return level1;
        }

        public static int HigherLvlOff(Officer[] District99)
        {
            int higherLevel = 0;

            for (int i = 0; i < District99.Length; i++)
            {
                if (District99[i].CalculateLevel() > 1)
                {
                    higherLevel++;
                }
            }
            return higherLevel;
        }

        public static void IsJohnHere(Officer[] District99)
        {
            bool isJohn = false;

            for (int i = 0; i < District99.Length; i++)
            {
                if (District99[i].Name == "John")
                {
                    isJohn = true;
                    break;
                }
            }

            if (isJohn == true)
            {
                Console.WriteLine("Atleast one officer is named John");
            }
            else
            {
                Console.WriteLine("There is noone named John working here");
            }
        }

        public void Show()
        {
            Console.WriteLine("Officer name is:" + this.name);
            Console.WriteLine("Officer surname is:" + this.surname);
            Console.WriteLine("Officer ID number is:" + this.officerID);
            Console.WriteLine("Officer's working district is:" + this.workingDistrict);
            Console.WriteLine("Officer has solved : " + this.crimesSolved + " " + "crimes");
            //Console.Write("Officer's level is:" + this.Level);
        }

        public override string ToString()
        {
            string stringValue = "Name : " + this.Name + " ; " + "Surname : " + this.Surname + " ; " + "ID Number : " + this.officerID + " ; "
                + "Working district : " + this.workingDistrict + " ; " + "Crimes solved : " + this.crimesSolved; 
            return stringValue;
        }
    }
}
