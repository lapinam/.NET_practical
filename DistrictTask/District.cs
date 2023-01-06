using System.Collections;

namespace DistrictTask
{
     class District
    {
        private string title;
        private string city;
        private int districtID;
        //these are several methods how to work with lists. Array[] is traditional
        //ArrayList is collections
        private Officer[] officersInTheDistrict;
        //private ArrayList officersInDistrict;
        private List<Officer> officersInDistrict;

        public District()
        {
            //this.officersInDistrict = new ArrayList();
            this.officersInDistrict= new List<Officer>();
        }

        public District(string name, string city, int districtID, Officer[] officersInTheDistrict)
        {
            this.title = name;
            this.city = city;
            this.districtID = districtID;
            this.officersInTheDistrict = officersInTheDistrict;
            //this.officersInDistrict = new ArrayList();
            this.officersInDistrict = new List<Officer>();
        }

        public string Name
        {
            get { return this.title; }
            set { this.title = value; }
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

        public ArrayList OfficersInDistrict 
        {
            get; set;
        }


        public override string ToString()
        {
            string stringValue = "District name : " + this.Name + " ; " + "City : " + this.city + " ; " + "District ID : " + this.districtID + " ; " +
             " ; " + "Officers in the district :" + this.officersInTheDistrict;
            return stringValue;
        }

        public bool AddOfficer(Officer officer)
        {
            this.officersInDistrict.Add(officer);
            return true;
        }

        public bool addNewOfficer(District district1)
        {
            District district1New = new District(this.title, this.city, this.DistrictID, this.officersInTheDistrict);

            for (int i = 0; i< officersInTheDistrict.Length; i++)
            {
                district1New.officersInTheDistrict[i] = district1.officersInTheDistrict[i];
            }

            district1New.officersInTheDistrict[officersInTheDistrict.Length + 1] = new Officer("NewName", "NewSurname", 0111, 50);
            return true;
        }

        public bool RemoveOfficer(Officer officer)
        {
            //foreach(Officer officername in this.officersInDistrict)
            //{
            //    We need to know index to remove so we use regular for
            //}

            //length for arrays, count for collections
            //for(int i=0; i<this.officersInDistrict.Count; i++)
            //{
            //    if (this.officersInDistrict[i] == officer)
            //    {
            //        this.officersInDistrict.RemoveAt(i);
            //        break;
            //    }
            //}

            this.officersInDistrict.Remove(officer);
            //better to use this defined method since collections have more efficient algorithms than our coded 
            //it checks the reference for which to remove (what does the reference looks like?)

            return true;
        }

        public bool removeOfficer(District district1)
        {
            Console.WriteLine("Which officer to remove? (enter number)");
            int nameRemove = Int32.Parse(Console.ReadLine());

            for (int i=0; i < officersInTheDistrict.Length; i++)
            {
                if (i == nameRemove);
                district1.officersInTheDistrict[i] = null;
}
            return true;
        }

        public float AverageLevel
        {
            get
            {
                if (this.officersInDistrict.Count == 0)
                    return -1;
                float levelSum = 0;
                foreach(Officer officer in officersInDistrict)
                {
                    levelSum += officer.Level;
                }
                return levelSum/this.officersInDistrict.Count;
            }
        }

        //we need static since we don't have anything related to current object
        public static float CalculateAverageLevel(District district1, District district2)
        {
            return (district1.AverageLevel + district2.AverageLevel / 2);
        }

        public static void CompareDistricts(District district1, District district2)
        {
            float avrgDist1 = district1.AverageLevel;
            float avrgDist2 = district2.AverageLevel;
            if (avrgDist1 > avrgDist2)
                Console.WriteLine("1>2");
            else if (avrgDist1 > avrgDist2)
                Console.WriteLine("2>1");
            else
                Console.WriteLine("same");
        }

        //traditional way how to compare; we pass one object and if is larger than where we called it from;
        //it shows -1; if object where it's called is larger than the one passed, it shows 1;
        public int Compare(District district)
        {
            float avrgDist1 = this.AverageLevel;
            float avrgDist2 = district.AverageLevel;
            if (avrgDist1 > avrgDist2)
                return 1;
            else if (avrgDist1 < avrgDist2)
                return -1;
            else
                return 0;
        }

        public float calculateAvgLevelInDistrict()
        {
            float avgLevel = 0;

            foreach (Officer officer in officersInTheDistrict) 
            {
                avgLevel += officer.CalculateLevel();
            }

            avgLevel = avgLevel/officersInTheDistrict.Length;
            return avgLevel;
        }
    }
}
