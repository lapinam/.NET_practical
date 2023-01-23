using MySqlConnector;

class Program
{

    public static void Main(string[] args)
    {
        //establishes connection to our server
        string connectionString = "server=localhost;uid=root;database=dotnetdemo";
        MySqlConnection connection= new MySqlConnection(connectionString); ;
        //opens collection
        connection.Open();

        MySqlCommand mySqlCommand = connection.CreateCommand();
        //provide SQL statement I want to execute
        mySqlCommand.CommandText = "SELECT * FROM Customer";
        MySqlDataReader reader = mySqlCommand.ExecuteReader();

        Console.WriteLine("ID;FirstName;Lasname;Email;Phone");
        //foreach (var line in reader) ...
        while (reader.Read())
        {
            Console.Write(reader.GetInt32(0));
            Console.Write(reader.GetString(1));
            Console.Write(reader.GetString(2));
            Console.Write(reader.GetString(3));
            Console.Write(reader.GetString(4));
            Console.Write(Environment.NewLine);
        }

        //closes collection
        connection.Close();
    }

}