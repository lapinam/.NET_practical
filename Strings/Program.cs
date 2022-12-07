class StringsTask
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter all the numbers (separated by space):");
        string array = Console.ReadLine();
        string[] numbersString = array.Split(" ");
        int arraySize = array.Length;
        int[] numbersInteger = new int[arraySize];
        int i = 0;

        for (i = 0; i < array.Length; i++)
        {
            numbersInteger[i] = Int32.Parse(numbersString[i]);
           
        }

        

        Console.WriteLine(numbersInteger);
        //convert the array of string to array of integers
        

    }
}