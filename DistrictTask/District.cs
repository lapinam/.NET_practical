namespace DistrictTask
{
     class District
    {
        private string name;
        private string city;
        private int districtID;
        private Officer[] officersInTheDistrict;

        public District()
        {

        }

        public District(string name, string city, int districtID, Officer[] officersInTheDistrict)
        {
            this.name = name;
            this.city = city;
            this.districtID = districtID;
            this.officersInTheDistrict = officersInTheDistrict;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        public int DistrictID
        {
            get { return this.districtID; }
            set { this.districtID = value; }
        }

        public Officer[] OfficersInTheDistrict
        {
            get { return this.officersInTheDistrict; }
            set { this.officersInTheDistrict = value; }
        }

        public override string ToString()
        {
            string stringValue = "District name : " + this.Name + " ; " + "City : " + this.city + " ; " + "District ID : " + this.districtID + " ; " +
             " ; " + "Officers in the district :" + this.officersInTheDistrict;
            return stringValue;
        }

        public bool addNewOfficer()
        {

        }

        public bool removeOfficer()
        {
            Console.WriteLine("Which officer to remove?");
            int nameRemove = Console.ReadLine();

            for (int i=0; i < District1.Lenth; i++)
            {
                if (this.name)
            }
        }
    }
}
