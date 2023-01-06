using System.Xml.Linq;

namespace OfficerTask
{
    class OfficerProject
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many officers are working here?");
            int arrLength = Int32.Parse(Console.ReadLine());
            Officer[] District99 = new Officer[arrLength];

            for (int i = 0; i < arrLength; i++) 
            {
                Officer officer = new Officer();
                District99[i] = officer;

                Console.WriteLine("Enter name:");
                officer.Name = Console.ReadLine();
                Console.WriteLine("Enter surname:");
                officer.Surname = Console.ReadLine();
                Console.WriteLine("Enter ID:");
                officer.OfficerID = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter working district:");
                officer.WorkingDistrict = Console.ReadLine();
                Console.WriteLine("Enter how many crimes you have solved:");
                officer.CrimesSolved = Int32.Parse(Console.ReadLine());

                
            }

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine(District99[i].ToString());
                //Console.WriteLine(District99[i]);
                //these two are the same since ToString is an override method from oObject parent
                //class (superclass) so you can write shorter code
            }

            Officer officerWhy = new Officer();
            Console.WriteLine(officerWhy.CalculateLevel());
            Console.WriteLine(officerWhy.Level);


            Console.WriteLine("There are " + Officer.Level1Off(District99) + " level 1 officers in this district.");
            Console.WriteLine("There are " + Officer.HigherLvlOff(District99) + " officers with higher level in this district.");
            Officer.IsJohnHere(District99);

        }
    }
}
