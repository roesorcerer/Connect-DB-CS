using System;
using System.Text;
using System.Data.SqlClient;
namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Connect to SQL Server and attempt Read operation.");

                // Build connection string 
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "servercop2664c.database.windows.net";   // update me 
                builder.UserID = "rowanstratton";     // update me 
                builder.Password = "123456";      // update me 
                builder.InitialCatalog = "COP2664CWinter2021"; // update me 

                // Connect to SQL 
                Console.Write("Connecting to SQL Server ... ");
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    Console.WriteLine("Done.");


                    // READ demo
                    Console.WriteLine("Reading data from table, press any key to continue...");
                    Console.ReadKey(true);
                    String sql = "USE [dbo].[Persons];";
                    StringBuilder sb = new StringBuilder();
                    sb.Clear();

                    // This tells the console what SELECT statement to execute.
                    sql = "SELECT FirstName, LastName, Address, City FROM [dbo].[Persons];";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                do
                                {
                                    Console.WriteLine("Press 1 to continue, 2 to end");
                                    int choice = Convert.ToInt32(Console.ReadLine());
                                    if (choice == 1)
                                    {
                                        // This prints the results of the query. Don't forget arrays always start counting at zero(0).
                                        Console.WriteLine("{0} {1} {2} {3}", reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                                    }
                                    else if (choice == 2)
                                    {
                                        Console.WriteLine("All done. Press any key to finish...");
                                        Console.ReadKey(true);
                                        break;
                                    }

                                }
                                while (true);
                                break;
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}
