namespace DistrictTask
{
    class DistrictProject
    {
        public static void Main(string[] args)
        {
            Officer officer1 = new Officer("Jacob", "Peralta", 0069, 15);
            Officer officer2 = new Officer("Rosa", "Diaz", 0070, 8);
            Officer officer3 = new Officer("Terrence", "Jeffords", 0040, 12);
            Officer officer4 = new Officer("Amy", "Santiago", 0074, 14);
            Officer officer5 = new Officer("Charles", "Boyle", 0055, 7);
            Officer officer6 = new Officer("Regina", "Linetti", 0100, 1);
            Officer officer7 = new Officer("Raymond", "Hoult", 0005, 35);

            Officer[] district1arr = new Officer[3];
            district1arr[0] = officer1;
            district1arr[1] = officer2;
            district1arr[2] = officer3;

            Officer[] district2arr = new Officer[4];
            district2arr[0] = officer4;
            district2arr[1] = officer5;
            district2arr[2] = officer6;
            district2arr[3] = officer7;

            District district1 = new District("Brooklyn 99", "New York", 001, district1arr);
            District district2 = new District("Hollywood 10", "Los Angeles", 002, district2arr);


        }
    }
}
