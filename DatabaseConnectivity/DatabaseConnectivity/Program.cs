using Microsoft.Data.SqlClient;
using System.Data;

namespace DatabaseConnectivity
{
    class Program
    {
        static void Main(string[] args)
        {
            //SQL Server Connection String
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SampleDB;Trusted_Connection=True;TrustServerCertificate=True;";

            //Fetch Query
            string sqlQuery = "SELECT Id,Name,Email FROM Users";

            //List of users
            List<User> usersList = new List<User>();

            //Connecting to SQL server
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Creating a connection
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                Console.WriteLine("Connecting To Database..");


                //Establish Connection
                try
                {
                    connection.Open();
                    Console.WriteLine("Successfully connected to Database!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Connecting Database..\n" + ex.Message);
                }


                if (connection.State == ConnectionState.Open)
                {
                    //Execute the query and fetching data
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //Read Data Until The End Of Data
                        Console.Write("Getting Data From Database..");
                        while (reader.Read())
                        {
                            //Assgin The Query Results Into Class Object
                            User user = new User
                            {
                                Id = reader.GetInt32(0), //Id As First Column
                                Name = reader.GetString(1), //Name As Second Column
                                Email = reader.GetString(2) //Email As Third Column
                            };

                            //Adding User Into List
                            usersList.Add(user);
                            Console.Write(".");
                        }
                    }
                    Console.WriteLine("");
                }
            }

            //Loop through the list of users and print
            Console.WriteLine("_________________________________________");
            foreach (var user in usersList)
            {
                Console.WriteLine($"Id: {user.Id}\t Name: {user.Name}\t Email: {user.Email}");
            }
        }
    }
}