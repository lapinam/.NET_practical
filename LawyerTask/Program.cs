namespace LawyerTask
{
    class LawyerProject
    {
        public static void Main(string[] args)
        {
            Officer officer1= new Officer("Jack", "Sparrow", 1, 30);
            Officer officer2 = new Officer("Mary", "Len", 2, 25);
            Officer officer3 = new Officer("Mar", "Wen", 3, 250);
            Officer officer4 = new Officer("Marta", "Yen", 4, 245);
            Officer officer5 = new Officer("Maria", "Oen", 5, 20);
            Officer officer6 = new Officer("Margo", "Gwen", 6, 16);
            Officer officer7 = new Officer("May", "Poem", 7, 2);

            District district1 = new District("District 1", "Riga", 1);
            District district2 = new District("District 2", "Vilnius", 2);
            District district3 = new District("District 3", "Kaunas", 3);

            district1.AddOfficer(officer1);
            district1.AddOfficer(officer2);

            district2.AddOfficer(officer3);
            district2.AddOfficer(officer4);

            district3.AddOfficer(officer5);
            district3.AddOfficer(officer6);
            district3.AddOfficer(officer7);
        }
    }
}