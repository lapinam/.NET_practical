using System.Linq.Expressions;

class Task30112022
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the array."); //how many elements in the sequence(integer array - numbers)
        int arraySize = UserInput.EnterIntNumber();
        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++) //what each element is (again only numbers)
        {
            Console.WriteLine("Enter the element" + " " + i); //same as ($"Enter the element {i}")
            int element = UserInput.EnterIntNumber();
            array[i] = element;
        }
        Console.Write("\n");

        bool noNegativeNumber = true;
        Console.WriteLine("The negative numbers in the sequence are:"); //writes if the element is a negative number
        foreach (int element in array)
        {
            if (element < 0)
            {
                noNegativeNumber = false;
                Console.WriteLine(element); //can use Console.Write() to write in the same line
            }
        }
        if (noNegativeNumber) //writes only if there are no negative numbers
            Console.WriteLine("None.");
        Console.Write("\n");

        //write all the elements in the same line
        //bool noNegativeNumber = true;
        //Console.Write("The negative numbers in the sequence are:"); //writes if the element is a negative number
        //foreach (int element in array)
        //{
        //    if (element < 0)
        //    {
        //        noNegativeNumber = false;
        //        Console.Write(element); //can use Console.Write() to write in the same line
        //    }
        //}
        //if (noNegativeNumber) //writes only if there are no negative numbers
        //    Console.Write("None.");
        //Console.Write("\n");


        Console.WriteLine("The odd numbers in the sequence are:"); //checks if the number is odd using modulo (dividing by 2 until there is 0 or 1 left)
        bool noOddNumbers = true;
        int oddElements = 0;
        foreach (int element in array)
        {
            //if (Math.Abs((element % 2 == 1)) uses absolute value since it can be 1 or -1
            if (element % 2 != 0)
            {
                noOddNumbers = false;
                Console.Write(element);
                oddElements++;
            }
        }
        if (noOddNumbers)
        {
            Console.WriteLine("None.");
        }
        Console.Write("\n"); 
        Console.WriteLine("There are" + " " + oddElements + " " + "odd elements in the array."); //counts the odd numbers
        Console.Write("\n");


        bool noSameNumbers= true;
        for (int i = 0; i < arraySize; i++) //compares if there are elements with the same value
        {
            for (int j = i + 1; j < arraySize; j++)
            {
                if (array[i] == array[j])
                {
                    noSameNumbers= false;
                    break; //return statement terminates execution of the function in which it appears and returns control and the function's result, if any, to the caller
                }
                //else
                //{
                //    //"If you require code to run only when the statement returns true (and do nothing else if false) then an else statement is not needed"
                //}
            }
        }
        if (!noSameNumbers)
            Console.WriteLine("There are multiple elements with the same value in the sequence.");
        else
            Console.WriteLine("There are no elements with the same value.");
        Console.Write("\n");

        //it's better to sort the array and check if identical to number next to it 
        //sorting algorithm
        //for (int i = 1; i < arraySize; i++)
        //{
        //    if (array[i] == array[i - 1]) ;
        //    {
        //        Console.WriteLine("Duplicates found");
        //        break;
        //    }
        //}


        Console.WriteLine("Every second element of the array is:"); //writes every second element, uses for loop where the step is 2
        for (int i = 1; i < arraySize; i += 2)
        {
            Console.Write(" " + array[i]);
        }
        Console.WriteLine("\n");


        double sum1 = 0; 
        foreach (int element in array) //counts every element for sum
        {
            sum1 += element; //a += 2 <=> a = a +2
        }
        double aver1 = sum1 / arraySize; //aver1 /= arrayLength <=> aver1 = aver1 / arrayLength
        Console.WriteLine("The average value of the array is:" + " " + aver1);


        int smallerThanAverage = 0;
        foreach (int element in array)
        {
            if (element < aver1)
            {
                smallerThanAverage++;
            }
        }
        Console.WriteLine("There are" + " " + smallerThanAverage + " " + "elements smaller than average value.");
    }
}
class UserInput
{
    public static int EnterIntNumber() //number input validation, accepts only integer
    {
        int input = 0;
        Console.WriteLine("Enter a number: ");
        while (true)
        {
            try
            {
                input = Int32.Parse(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("This is not a number. Please try again.");
            }
        }
        return input;
    }
}

class Calculations
{
    //public static void DividedByTwo(int val1)
    //{
    //    if (val1 >= 2)
    //    {
    //        do
    //        {
    //            int division = val1 / 2;
    //            break;
    //        }
    //        while (division > 2);
    //        return;
    //    }
 }
