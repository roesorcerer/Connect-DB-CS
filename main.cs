using System;
using System.Text;
using System.Data.SqlClient;
namespace SqlServerSample
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
                builder.DataSource = "servercop2664c.database.windows.net";   
                builder.UserID = "rowanstratton";     // username 
                builder.Password = "Password8!";      // pass 
                builder.InitialCatalog = "COP2664CWinter2021";

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
                    StringBuilder sb = new StringBuilder();
                    sb.Clear();

                    // This tells the console what SELECT statement to execute. 
                    sql = "SELECT FirstName, LastName, CompanyName, SalesPerson FROM [SalesLT].[Customer];";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
//                            while (reader.Read())
 //                           {
                                // This prints the results of the query. Don't forget arrays always start counting at zero(0). 
                                Console.WriteLine("Hello World!");
  //                              Console.WriteLine("{0} {1} {2} {3}", reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
  //                          }
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
