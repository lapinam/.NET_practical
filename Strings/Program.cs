class StringsTask
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter all the numbers (separated by space):");
        string[] array = Console.ReadLine().Split(" ");
        //string[] numbersString = array.Split(" ");
        int[] numbersInteger = new int[array.Length];
        
        for (int i = 0; i < array.Length; i++)
        {
            
            numbersInteger[i] = Convert.ToInt32(array[i]);
        }
              

        Console.WriteLine(numbersInteger);
        //convert the array of string to array of integers
        

    }
}