namespace LawyerTask
{
    class Officer : Person
    {
        //private string name;
        //private string surname;
        private int officerID;
        private int crimesSolved;

        public Officer()
        {

        }

        public Officer(string name, string surname,int officerID, int crimesSolved) : base(name, surname)
        {
            //this.Name = name;
            //this.Surname = surname;
            this.OfficerID = officerID;
            this.CrimesSolved = crimesSolved;
        }

        //public string Name
        //{
        //    get { return this.name; }
        //    set { this.name = value; }
        //}

        //public string Surname
        //{
        //    get { return this.surname; }
        //    set { this.surname = value; }
        //}

        public int OfficerID
        {
            get { return this.officerID; }
            set { this.officerID = value; }
        }


        public int CrimesSolved
        {
            get { return this.crimesSolved; }
            set { this.crimesSolved = value; }
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

        public int Level //additional way how to get level
        {
            get
            {
                return this.CalculateLevel();
            }
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

        //public void Show()
        //{
        //    Console.WriteLine("Officer name is:" + this.name);
        //    Console.WriteLine("Officer surname is:" + this.surname);
        //    Console.WriteLine("Officer ID number is:" + this.officerID);
        //    Console.WriteLine("Officer has solved : " + this.crimesSolved + " " + "crimes");
        //    //Console.Write("Officer's level is:" + this.Level);
        //}

        public override string ToString()
        {
            string stringValue = 
                "ID Number : " + this.officerID + " ; " +
             " ; " + "Crimes solved : " + this.crimesSolved;
            return base.ToString() + " " + stringValue;
        }
    }
}
