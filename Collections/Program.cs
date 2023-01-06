class Program
{
    public static void Main(string[] args)
    {
        List<string> list = new List<string>();
        list.Add("Element");//OK
        //list.Add(5556);//not Ok since not a string but int

        list.RemoveAt(0);//removes element at the position 0
        //list.ForEach(x => list.Add(x));//lambda expression
        
    }
}