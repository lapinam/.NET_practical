
namespace PersonTask2
{
    class Date
    {
        private int day, month, year;

        public int Day
        {
            get
            {
                return this.day;
            }
            set
            {
                if (value < 1 || value > 31)
                    Console.WriteLine("This is not a valid day");
                else
                    this.day = value;
            }
        }

        public int Month
        {
            get
            {
                return this.month;
            }
            set
            {
                if (value < 1 || value > 12)
                    Console.WriteLine("This is not a valid month");
                else
                    this.month = value;
            }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public Date(string value1)
        {
            this.GetDate(value1);
        }

        public void GetDate(string value1)
        {
            string[] dateSplit = value1.Split(".");

            this.Day = Convert.ToInt32(dateSplit[0]);
            this.Month = Convert.ToInt32(dateSplit[1]);
            this.Year = Convert.ToInt32(dateSplit[2]);
        }


        public int GetCurrentAge(Person person)
        {
            
            DateOnly dateOfBirth = new DateOnly(this.Year, this.Month, this.Day);
            int today = Int32.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int birthday = Int32.Parse(dateOfBirth.ToString());
            int currentAge = (today - birthday) / 10000;
            return currentAge;
        }
    }
}
