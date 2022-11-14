class Practical1
{


    static void Main(string[] args)
    {

        //int valint = 7;
        //double valdoub = valint; //casting done automatically, because there
        //is no potential data loss
        //console.writeline(valdoub);
        //valdoub = 10.56;
        //valint = (int)valdoub; //casting done manually, because there is
        //the potential data loss
        //console.writeline(valint);
        //char charvar = 'b';
        //valint = (int)charvar;
        //console.writeline(valint);

        //string strl1 = "c:\\users\\lapin\\desktop\\sgt\\dotnetprojects";
        //string strl2 = @"c:\users\lapin\desktop\sgt\dotnetprojects";

        Console.WriteLine("Please enter something:");
        string input = Console.ReadLine();
        Console.WriteLine("Please enter something again:");
        string input2 = Console.ReadLine();
        string result = input + input2;
        Console.WriteLine(result);
    //    //Console.WriteLine(input);
    //    Console.WriteLine("You entered : {0}", input);
    }
}