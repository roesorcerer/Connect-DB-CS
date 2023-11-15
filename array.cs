using System;
using System.Text;
using System.Data.SqlClient;
namespace Module4B
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
                builder.UserID = "annastratton";     // update me 
                builder.Password = "Password8!";      // update me 
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
                    String sql = "USE [SalesLT].[Customer];";
                    String sql2 = "USE [SalesLT].[Customer];";

                    StringBuilder sb = new StringBuilder();
                    sb.Clear();

                    // This tells the console what SELECT statement to execute. 
                    sql = "SELECT FirstName, LastName, CompanyName, SalesPerson FROM [SalesLT].[Customer];";
                    sql2 = "SELECT TOP 5 FirstName, LastName FROM [SalesLT].[Customer];";

                    string[] names = new string[5];
                    names[0] = sql2;
                    using (SqlCommand command = new SqlCommand(sql2, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // This prints the results of the query. Don't forget arrays always start counting at zero(0). 
                                Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("All done. Press any key to finish...");
            Console.ReadKey(true);
        }
    }
}
