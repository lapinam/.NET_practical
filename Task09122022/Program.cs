using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;
using Microsoft.VisualBasic;

class OOP
{
    public static void Main(string[] args)
    {
        Person newPerson = new Person();
        Console.WriteLine("Enter your name:");
        newPerson.Name = Console.ReadLine();

        Console.WriteLine("Enter your surname:");
        newPerson.Surname = Console.ReadLine();

        

    }
}

class Person
{
    private string name;
    private string surname;
    private DateOnly dateOfBirth;

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

    public string GetFullName
    {
        get { return this.name + " " + this.surname; }
        //StringBuilder getFullName = new StringBuilder(name, surname);
        //return getFullName.ToString();
    }

    public string CalculateFullName()
    {
        return this.name + " " + this.surname;
    }
}


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

    public void SetDate(string dateStr, string format)
    {
        string[] formatSplit = format.Split("-");
        string[] dateSplit = dateStr.Split("-");

        if (formatSplit[0] == "dd")
        {
            this.Day = Convert.ToInt32(dateSplit[0]);
        }
        else if (formatSplit[0] == "mm")
        {
            this.Month = Convert.ToInt32(dateSplit[0]);
        }
        else if (formatSplit[0] == "yyyy")
        {
            this.Year= Convert.ToInt32(dateSplit[0]);
        }
        else
        {
            Console.WriteLine("Wrong date format");
            return;
        }

        if (formatSplit[1] == "dd")
        {
            this.Day = Convert.ToInt32(dateSplit[0]);
        }
        else if (formatSplit[1] == "mm")
        {
            this.Month = Convert.ToInt32(dateSplit[0]);
        }
        else if (formatSplit[1] == "yyyy")
        {
            this.Year = Convert.ToInt32(dateSplit[0]);
        }
        else
        {
            Console.WriteLine("Wrong date format");
            return;
        }

        if (formatSplit[2] == "dd")
        {
            this.Day = Convert.ToInt32(dateSplit[0]);
        }
        else if (formatSplit[2] == "mm")
        {
            this.Month = Convert.ToInt32(dateSplit[0]);
        }
        else if (formatSplit[2] == "yyyy")
        {
            this.Year = Convert.ToInt32(dateSplit[0]);
        }
        else
        {
            Console.WriteLine("Wrong date format");
            return;
        }
    }

    public int GetCurrentAge()
    {
        DateOnly dateOfBirth = new DateOnly(this.Year, this.Month, this.Day);
        int today = Int32.Parse(DateTime.Now.ToString("yyyyMMdd"));
        int birthday = Int32.Parse(dateOfBirth.ToString());
        int currentAge = (today - birthday) / 10000;
        return currentAge;
    }
}
